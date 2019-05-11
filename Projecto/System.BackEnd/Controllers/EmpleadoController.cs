using System;
using System.Collections.Generic;
using System.Linq;
using System.Services;
using System.Services.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace System.Backend.Controllers
{
    public class EmpleadoController : CommonController
    {
        private readonly ILogger<EmpleadoController> _logger;
        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            EmpleadoService empleadoService = new EmpleadoService(_logger);
            var empleado = empleadoService.GetAll();
            return View(empleado);
        }
        [HttpGet]
        public async Task<IActionResult> GridEmpleados(string nombre = null, string apellido = null, string dni = null)
        {
            EmpleadoService empleadoService = new EmpleadoService(_logger);
            var model = new List<EmpleadoViewModel>();
            await Task.Run(() => model = empleadoService.GetAll(nombre, apellido, dni));
            return PartialView("_GridIndex", model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create (EmpleadoViewModel model)
        {
            try
            {
                EmpleadoService empleadoService = new EmpleadoService(_logger);
                empleadoService.Create(model);
                _logger.LogInformation("Empleado creado");
                SetTempData("Empleado creado correctamente", "success");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError("Ocurrio un error crear el empleado. Error {0}", e);
                SetTempData("No se pudo crear el empleado", "error");
                return RedirectToAction("Index");
            }
        }
        public IActionResult Edit(int Id)
        {
            EmpleadoService empleadoService = new EmpleadoService(_logger);
            var model = empleadoService.GetById(Id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit (EmpleadoViewModel model)
        {
            try
            {
                EmpleadoService empleadoService = new EmpleadoService(_logger);
                empleadoService.Edit(model);
                _logger.LogInformation("Empleado Editado");
                SetTempData("Empleado editado correctamente", "success");
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                _logger.LogError("Ocurrio un error al editar el empleado. Error: {0}", e);
                SetTempData("Ocurrio un error al intetar editar el empleado", "error");
                return RedirectToAction("Index");
            }
        }
        public IActionResult Delete (int Id)
        {
            try
            {
                EmpleadoService empleadoService = new EmpleadoService(_logger);
                empleadoService.Delete(Id);
                _logger.LogInformation("Empleado eliminado");
                SetTempData("Empleado eliminado");
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                _logger.LogError("Ocurrio un error al eliminar el empleado. Error: {0}", e);
                SetTempData("Ocurrio un error al eliminar el empleado", "error");
                return RedirectToAction("Index");
            }
        }
    }
}