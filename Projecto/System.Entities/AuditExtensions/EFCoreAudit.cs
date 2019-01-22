using System;
using System.Collections.Generic;
using System.Linq;
using Audit.Core;
using Audit.Core.Providers;
using Audit.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace System.Entities.AuditExtensions
{
    [AuditDbContext(Mode = AuditOptionMode.OptOut, IncludeEntityObjects = true, AuditEventType = "{database}_{context}")]
    public class EFCoreAudit : AuditDbContext
    {
        protected List<string> ignoredColumns = new List<string>(new string[] { "TSCreate", "TSModificado", "TSUltimoUso" });
        public EFCoreAudit(DbContextOptions<System.Entities.SystemContext> options) : base(options)
        {
            var dataProvider = new DynamicDataProvider();
            dataProvider.AttachOnInsert(ev => Console.Write(ev.ToJson()));
            Audit.Core.Configuration.DataProvider = dataProvider;
        }

        public override void OnScopeCreated(AuditScope auditScope)
        {
            auditScope.Event.GetEntityFrameworkEvent().TransactionId = Guid.NewGuid().ToString();
            Database.BeginTransaction();
        }

        public override void OnScopeSaving(AuditScope auditScope)
        {
            try
            {
                // ... custom log saving ...
                UnitOfWork _uow = new UnitOfWork();
                var date = DateTime.Now;
                var entryList = auditScope.Event.GetEntityFrameworkEvent().Entries;
                //TODO: Revisar nombre devuelto en servidor
                var userName = /*auditScope.Event.Environment.DomainName + "\\" +*/ auditScope.Event.Environment.UserName;
                foreach (var entry in entryList.Where(x => x.Action == "Update"))
                {
                    List<AuditChangeModel> changeModelList = new List<AuditChangeModel>();
                    foreach (var change in entry.Changes)
                    {
                        if (change != null && change.NewValue != null && change.OriginalValue != null && !change.NewValue.Equals(change.OriginalValue) && !ignoredColumns.Contains(change.ColumnName))
                        {
                            AuditChangeModel changeModel = new AuditChangeModel
                            {
                                ColumnName = change.ColumnName,
                                OldValue = change.OriginalValue,
                                NewValue = change.NewValue
                            };
                            changeModelList.Add(changeModel);
                        }
                    }
                    if (changeModelList.Count > 0)
                    {
                        _uow.AuditoriaRepository.Create(new Auditoria()
                        {
                            UserName = userName,
                            Date = date,
                            Entity = entry.Table,
                            EntityId = entry.PrimaryKey[entry.Table + "Id"].ToString(),
                            Action = entry.Action,
                            Value = JsonConvert.SerializeObject(changeModelList),
                            TransactionId = auditScope.Event.GetEntityFrameworkEvent().TransactionId,
                            Descripcion = "Se actualizó el registro ID " + entry.PrimaryKey[entry.Table + "Id"].ToString() + " de la tabla " + entry.Table
                        });
                    }
                }
                var entitiesCreatedList = entryList.Where(x => x.Action == "Insert").Select(x => x.Table).Distinct();
                foreach (var table in entitiesCreatedList)
                {
                    foreach (var entry in entryList.Where(x => x.Action == "Insert" && x.Table == table))
                    {
                        var entriesDeleted = entryList.Where(x => x.Action == "Delete").Select(x => x.PrimaryKey);
                        if (!DictionaryContains(entriesDeleted, entry.PrimaryKey))
                        {
                            Auditoria auditoria = new Auditoria
                            {
                                UserName = userName,
                                Date = date,
                                Entity = entry.Table,
                                Action = entry.Action,
                                TransactionId = auditScope.Event.GetEntityFrameworkEvent().TransactionId,
                                Descripcion = "Nuevo registro en la tabla " + entry.Table
                            };
                            auditoria.Value = JsonConvert.SerializeObject((dynamic)entry.Entity,
                                                                Formatting.Indented,
                                                                new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                            _uow.AuditoriaRepository.Create(auditoria);
                        }
                    }
                }
                var entitiesDeletedList = entryList.Where(x => x.Action == "Delete").Select(x => x.Table).Distinct();
                foreach (var table in entitiesDeletedList)
                {
                    foreach (var entry in entryList.Where(x => x.Action == "Delete" && x.Table == table))
                    {
                        var entriesCreated = entryList.Where(x => x.Action == "Insert").Select(x => x.PrimaryKey);
                        if (!DictionaryContains(entriesCreated, entry.PrimaryKey))
                        {
                            _uow.AuditoriaRepository.Create(new Auditoria()
                            {
                                UserName = userName,
                                Date = date,
                                Entity = entry.Table,
                                //EntityId = entry.PrimaryKey[entry.Table + "Id"].ToString(),
                                Action = entry.Action,
                                Value = JsonConvert.SerializeObject((dynamic)entry.Entity,
                                                                    Formatting.None,
                                                                    new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore }),
                                TransactionId = auditScope.Event.GetEntityFrameworkEvent().TransactionId,
                                Descripcion = "Registro eliminado de la tabla " + entry.Table
                            });
                        }
                    }
                }
                _uow.Save();
            }
            catch
            {
                // Rollback call is not mandatory. If exception thrown, the transaction won't get commited
                Database.CurrentTransaction.Rollback();
                throw;
            }
            Database.CurrentTransaction.Commit();
        }
        public bool DictionaryContains(IEnumerable<IDictionary<string, object>> dictionaryList, IDictionary<string, object> dictionary)
        {
            foreach (var d in dictionaryList)
            {
                if (DictionaryEquals(d, dictionary))
                    return true;
            }
            return false;
        }
        public bool DictionaryEquals(IDictionary<string, object> x, IDictionary<string, object> y)
        {
            // early-exit checks
            if (null == y)
                return null == x;
            if (null == x)
                return false;
            if (object.ReferenceEquals(x, y))
                return true;
            if (x.Count != y.Count)
                return false;

            // check keys are the same
            foreach (string k in x.Keys)
                if (!y.ContainsKey(k))
                    return false;

            // check values are the same
            foreach (string k in x.Keys)
                if (!x[k].Equals(y[k]))
                    return false;

            return true;
        }
    }
}
