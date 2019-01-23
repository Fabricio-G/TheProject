using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Services;
using System.Services.Models;

namespace System.Backend.Controllers
{
    public class MarcaController : CommonController
    {
        private readonly ILogger<MarcaController> _logger;
        public MarcaController(ILogger<MarcaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            MarcaService marcaService = new MarcaService(_logger);
            var model = marcaService.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MarcaViewModel marcaModel)
        {
            MarcaService marcaService = new MarcaService(_logger);
            marcaService.Create(marcaModel);
            SetTempData("Marca Creada.");
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            MarcaService marcaService = new MarcaService(_logger);
            var model = marcaService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(MarcaViewModel modelMarca)
        {
            MarcaService marcaService = new MarcaService(_logger);
            marcaService.Edit(modelMarca);
            SetTempData("Marca Editada.");
            return RedirectToAction("Index");
        }

        public IActionResult Delete (int id)
        {
            MarcaService marcaService = new MarcaService(_logger);
            marcaService.Delete(id);
            SetTempData("Marca Eliminada.");
            return RedirectToAction("Index");
        }
    }
}