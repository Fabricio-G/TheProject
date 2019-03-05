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
    }
}