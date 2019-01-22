using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Backend.Models;
using System.Services;
using Parametro = System.Helper.Parametro;

namespace System.Backend.Controllers
{
    public class AuditoriaController : CommonController
    {
        protected AuditoriaService auService;
        private readonly ILogger<AuditoriaController> _logger;
        private readonly IOptions<AppSettings> _appSettings;

        public AuditoriaController(ILogger<AuditoriaController> logger, IOptions<AppSettings> options)
        {
            _logger = logger;
            auService = new AuditoriaService(_logger);
            _appSettings = options;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["AppTitle"] = Parametro.GetValue("AppTitle").ToString();
            return View();
        }
        [HttpGet]
        public IActionResult AuditoriaGrid(string UserName = null, string Entity = null, string DateFrom = null, string DateTo = null, string ActionChange = null, string Description = null, int? page = null, int? rows = null)
        {
            AuditoriaService auditoriaService = new AuditoriaService(_logger);
            var filtros = new Services.Models.GridFilterModel()
            {
                rowPerPages = _appSettings.Value.Paging.RowsPerPage,
                fechaDesde = DateFrom,
                fechaHasta = DateTo,
                page = page,
                rows = rows
            };
            return PartialView("_GridAuditoria", auditoriaService.GetAll(filtros, UserName, Entity, ActionChange, Description));
        }

        [HttpGet]
        public IActionResult AuditoriaExportList(string UserName = null, string Entity = null, string DateFrom = null, string DateTo = null, string ActionChange = null, string Description = null)
        {
            try
            {
                var result = auService.ExportToExcel(UserName, Entity, DateFrom, DateTo, ActionChange, Description);
                return result;
            }
            catch (Exception ex)
            {
                SetTempData(ex.Message, "error");
                return RedirectToAction("Index", "Auditoria");
            }
        }

        public JsonResult GetAuditoriaJson(int id)
        {
            try
            {
                AuditoriaService auditoriaService = new AuditoriaService(_logger);
                var registro = auditoriaService.GetById(id);
                return Json(registro);
            }
            catch (Exception ex)
            {
                var error = "Imposible obtener Json: "+ex.Message;
                return Json(error);
            }

        }
    }

}