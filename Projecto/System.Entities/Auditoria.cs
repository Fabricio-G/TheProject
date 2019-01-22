using System;
using Audit.EntityFramework;
using System.Entities.Repository.Interface;

namespace System.Entities
{
    [AuditIgnore]
    public class Auditoria : IEntity
    {
        public int AuditoriaId { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Entity { get; set; }
        public string EntityId { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }
        public string TransactionId { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public DateTime? TSCreate { get; set; }
        public DateTime? TSModificado { get; set; }
        public DateTime? TSEliminado { get; set; }
    }
}
