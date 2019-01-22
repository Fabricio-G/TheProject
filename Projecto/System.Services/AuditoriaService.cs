using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Entities;
using System.Entities.AuditExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Helper.Extensions;
using System.Services.Models;

namespace System.Services
{
    public class AuditoriaService
    {
        private readonly ILogger _logger;
        readonly UnitOfWork _uow = new UnitOfWork();

        public AuditoriaService(ILogger logger)
        {
            _logger = logger;
        }

        public GridAuditoriaModel GetAll(GridFilterModel filtros, string UserName = null, string Entity = null, string Action = null, string Description = null)
        {
            var model = new GridAuditoriaModel
            {
                AuditoriaList = new List<AuditoriaModel>()
            };

            try
            {
                var query = _uow.AuditoriaRepository.All().OrderByDescending(x => x.Date).AsQueryable();

                //Filtros
                if (!String.IsNullOrWhiteSpace(UserName))
                    query = query.Where(x => x.UserName.ToLower().Contains(UserName.ToLower()));
                if (!String.IsNullOrWhiteSpace(Entity))
                    query = query.Where(x => x.Entity.ToLower().Contains(Entity.ToLower()));
                if (!String.IsNullOrWhiteSpace(Action))
                    query = query.Where(x => x.Action.ToLower().Contains(Action.ToLower()));
                if (!String.IsNullOrWhiteSpace(Description))
                    query = query.Where(x => x.Descripcion.ToLower().Contains(Description.ToLower()));
                if (!String.IsNullOrWhiteSpace(filtros.fechaDesde))
                {
                    var dateSplit = filtros.fechaDesde.Split(" ")[0].Split("/");
                    DateTime dateFromFilter = new DateTime(int.Parse(dateSplit[2]), int.Parse(dateSplit[1]), int.Parse(dateSplit[0]), 0, 0, 0);
                    query = query.Where(x => x.Date >= dateFromFilter);
                }
                if (!String.IsNullOrWhiteSpace(filtros.fechaHasta))
                {
                    var dateSplit = filtros.fechaHasta.Split(" ")[0].Split("/");
                    DateTime dateToFilter = new DateTime(int.Parse(dateSplit[2]), int.Parse(dateSplit[1]), int.Parse(dateSplit[0]), 23, 59, 0);
                    query = query.Where(x => x.Date <= dateToFilter);
                }
                if (!String.IsNullOrWhiteSpace(Action))
                    query = query.Where(x => x.Action.ToLower().Contains(Action.ToLower()));
                //-----

                var totalRows = query.Count();
                query = query.Skip((filtros.page - 1 ?? 0) * (filtros.rows ?? filtros.rowPerPages)).Take(filtros.rows ?? filtros.rowPerPages);
                model.TotalRows = totalRows;


                var listado = query.OrderByDescending(x => x.Date)

                    .Select(x => new AuditoriaModel()
                    {
                        AuditoriaId = x.AuditoriaId,
                        TransactionId = x.TransactionId,
                        Fecha = x.Date,
                        UserName = x.UserName,
                        Entity = x.Entity,
                        EntityId = x.EntityId,
                        Action = x.Action,
                        Descripcion = x.Descripcion
                    }).OrderByDescending(x => x.Fecha).ToList();

                model.AuditoriaList = listado;
                return model;
            }
            catch (Exception ex)
            {
                _logger.LogErrorException(ex, "Ocurrió un problema al intentar obtener lista completa de Auditoría");
                return new GridAuditoriaModel();
            }
        }

        public AuditoriaModel GetById(int id)
        {
            var registro = _uow.AuditoriaRepository.Find(x => x.AuditoriaId == id);

            var model = new AuditoriaModel()
            {
                AuditoriaId = registro.AuditoriaId,
                Value = registro.Value
            };

            return model;
        }

        #region FILTRADO EXCEL

        public FileStreamResult ExportToExcel(string UserName = null, string Entity = null, string DateFrom = null, string DateTo = null, string ActionChange = null, string Description = null)
        {
            try
            {
                string sheetname = @"Auditoria_" + DateTime.Now.ToString("ddMMyyyy_hhmmss") + ".xlsx";
                var stream = new MemoryStream();

                using (ExcelPackage package = new ExcelPackage())
                {

                    var listAuditoria = GetAllForExport(UserName, Entity, DateFrom, DateTo, ActionChange, Description);
                    string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(DateTime.Now.ToString("dd-MM-yyyy hhmmss"));
                    int totalRows = listAuditoria.Count;

                    //HEADER PRINCIPAL
                    worksheet.Cells["A1:F1"].Value = "REGISTROS DE AUDITORÍA - " + DateTime.Now;
                    worksheet.Cells["A1:F1"].Style.Font.Bold = true;
                    worksheet.Cells["A1:F1"].Style.Font.Size = 17;
                    worksheet.Cells["A1:F1"].Style.Font.Color.SetColor(Color.White);
                    worksheet.Row(1).Height = 45;
                    var border = worksheet.Cells["A1:F1"].Style.Border;
                    border.Bottom.Style = border.Left.Style = border.Right.Style = border.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["A1:F1"].Merge = true;
                    worksheet.Cells["A1:F1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["A1:F1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(63, 81, 180));

                    //NOMBRE COLUMNAS
                    worksheet.Cells["A2"].Value = "ID";
                    worksheet.Cells["B2"].Value = "Fecha";
                    worksheet.Cells["C2"].Value = "Usuario";
                    worksheet.Cells["D2"].Value = "Tabla";
                    worksheet.Cells["E2"].Value = "Acción";
                    worksheet.Cells["F2"].Value = "Descripción";
                    worksheet.Cells["A2:F2"].Style.Font.Bold = true;
                    border = worksheet.Cells["A2:F2"].Style.Border;
                    worksheet.Cells["A2:F2"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["A2:F2"].Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                    border.Bottom.Style = border.Top.Style = border.Left.Style = border.Right.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["A2:F2"].AutoFitColumns();
                    worksheet.Cells["A2:F2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    //Ajuste de ancho exclusivo para columnas específicas:
                    worksheet.Column(1).Width = 10;
                    worksheet.Column(2).Width = 18;
                    worksheet.Column(3).Width = 18;
                    worksheet.Column(4).Width = 18;
                    worksheet.Column(5).Width = 13;
                    worksheet.Column(6).Width = 85;

                    //Alineado Horizontal:
                    worksheet.Column(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    worksheet.Column(2).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Column(3).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Column(4).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Column(5).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Column(6).Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    worksheet.Cells["F2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    //Alineado Vertical:
                    worksheet.Column(1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Column(2).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Column(3).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Column(4).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Column(5).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Column(6).Style.VerticalAlignment = ExcelVerticalAlignment.Top;

                    //DATOS
                    for (var x = 3; x < totalRows + 3; x++)
                    {
                        worksheet.Cells["A" + x].Value = listAuditoria[x - 3].AuditoriaId;
                        worksheet.Cells["B" + x].Value = listAuditoria[x - 3].Fecha.ToString("dd/MM/yyyy HH:mm");
                        worksheet.Cells["C" + x].Value = listAuditoria[x - 3].UserName ?? "";
                        worksheet.Cells["D" + x].Value = listAuditoria[x - 3].Entity;
                        worksheet.Cells["E" + x].Value = listAuditoria[x - 3].Action;
                        //Variables auxiliares...
                        var description = listAuditoria[x - 3].Descripcion;
                        var jsonClean = string.Empty;
                        var valCell = "";

                        jsonClean = listAuditoria[x - 3].Value;
                        jsonClean = jsonClean.Replace("\r", "").Replace("\n", "");

                        //Si es Update, deserializo json a modelo AuditChangeModel.
                        if (listAuditoria[x - 3].Action.Equals("Update"))
                        {
                            if (!jsonClean.Contains('[')) //Algunos registros update no contienen corchetes de apertura y cierre de array...
                            {
                                jsonClean = "[" + jsonClean + "]"; //Añado corchetes necesarios para serializar a List<AuditChangeModel>
                            }

                            var listUpdateModel = JsonConvert.DeserializeObject<List<AuditChangeModel>>(jsonClean.ToString());
                            valCell += description + Environment.NewLine + Environment.NewLine;
                            foreach (var values in listUpdateModel)
                            {
                                valCell += nameof(values.ColumnName) + ": " + values.ColumnName + Environment.NewLine + nameof(values.OldValue) + ": " + values.OldValue + Environment.NewLine + nameof(values.NewValue) + ": " + values.NewValue + Environment.NewLine + Environment.NewLine;
                            }
                        }
                        else
                        {
                            //Utilizo objeto json directamente...
                            jsonClean = jsonClean.Replace("\r", "").Replace("\n", "");
                            var datos = JObject.Parse(jsonClean);
                            valCell += description + Environment.NewLine + Environment.NewLine;
                            foreach (var d in datos)
                            {
                                valCell += String.IsNullOrEmpty(d.Value.ToString()) ? d.Key + ": " + "null" + Environment.NewLine : d.Key + ": " + d.Value + Environment.NewLine;
                            }
                        }
                        worksheet.Cells["F" + x].Value = valCell;
                        worksheet.Cells["F" + x].Style.WrapText = true;
                    }
                    border = worksheet.Cells["A3:F" + (totalRows + 2).ToString()].Style.Border;
                    border.Bottom.Style = border.Top.Style = border.Left.Style = border.Right.Style = ExcelBorderStyle.Thin;
                    //REAJUSTE DE ALINEACIÓN TITULO HEADER:
                    worksheet.Cells["A1:F1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A1:F1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    //FOOTER PRINCIPAL
                    totalRows = totalRows + 3;
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Value = "PlusPagos - ©" + System.DateTime.Now.Year.ToString();
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Style.Font.Italic = true;
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Style.Font.Size = 13;
                    var borderFooter = worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Style.Border;
                    borderFooter.Bottom.Style = borderFooter.Left.Style = borderFooter.Right.Style = borderFooter.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Merge = true;
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells["A" + totalRows + ":F" + totalRows + ""].Style.Fill.BackgroundColor.SetColor(Color.LightGray);

                    package.SaveAs(stream);
                    stream.Position = 0;
                    var resultado = new FileStreamResult(stream, contentType)
                    {
                        FileDownloadName = sheetname
                    };

                    _logger.LogInformation("Se exportó exitosamente archivo Excel de Registro de Auditoría.");

                    return resultado;
                }
            }
            catch (Exception ex)
            {
                _logger.LogErrorException(ex, "Ocurrió un problema al intentar exportar a Excel el Registro de Auditoría");
                throw new InvalidOperationException("Error al intentar exportar a Auditoría");
            }
        }

        public List<AuditoriaModel> GetAllForExport(string UserName = null, string Entity = null, string DateFrom = null, string DateTo = null, string Action = null, string Description = null)
        {
            try
            {
                var query = _uow.AuditoriaRepository.All();

                //Filtros
                if (!String.IsNullOrWhiteSpace(UserName))
                    query = query.Where(x => x.UserName.ToLower().Contains(UserName.ToLower()));
                if (!String.IsNullOrWhiteSpace(Entity))
                    query = query.Where(x => x.Entity.ToLower().Contains(Entity.ToLower()));
                if (!String.IsNullOrWhiteSpace(Action))
                    query = query.Where(x => x.Action.ToLower().Contains(Action.ToLower()));
                if (!String.IsNullOrWhiteSpace(Description))
                    query = query.Where(x => x.Descripcion.ToLower().Contains(Description.ToLower()));
                if (!String.IsNullOrWhiteSpace(DateFrom))
                {
                    var dateSplit = DateFrom.Split(" ")[0].Split("/");
                    DateTime dateFromFilter = new DateTime(int.Parse(dateSplit[2]), int.Parse(dateSplit[1]), int.Parse(dateSplit[0]), 0, 0, 0);
                    query = query.Where(x => x.Date >= dateFromFilter);
                }
                if (!String.IsNullOrWhiteSpace(DateTo))
                {
                    var dateSplit = DateTo.Split(" ")[0].Split("/");
                    DateTime dateToFilter = new DateTime(int.Parse(dateSplit[2]), int.Parse(dateSplit[1]), int.Parse(dateSplit[0]), 23, 59, 0);
                    query = query.Where(x => x.Date <= dateToFilter);
                }
                if (!String.IsNullOrWhiteSpace(Action))
                    query = query.Where(x => x.Action.ToLower().Contains(Action.ToLower()));
                //-----

                var model = query.OrderByDescending(x => x.Date)
                                .Select(x => new AuditoriaModel()
                                {
                                    AuditoriaId = x.AuditoriaId,
                                    Fecha = x.Date,
                                    UserName = x.UserName,
                                    Entity = x.Entity,
                                    Action = x.Action,
                                    Value = x.Value,
                                    Descripcion = x.Descripcion
                                }).ToList();

                return model;
            }
            catch (Exception ex)
            {
                _logger.LogErrorException(ex, "Ocurrió un problema al intentar obtener lista completa de Auditoría");
                return new List<AuditoriaModel>();
            }
        }


        #endregion

    }
}