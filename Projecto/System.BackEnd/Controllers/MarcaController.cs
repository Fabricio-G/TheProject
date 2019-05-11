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
            try
            {
                MarcaService marcaService = new MarcaService(_logger);
                var model = marcaService.GetAll();
                _logger.LogInformation("Listado de marcas obtenido correctamente");
                return View(model);
            }
            catch (Exception e)
            {
                _logger.LogError("Ocurrio un error al obtener el listado de Marcas. Error {0}", e);
                return BadRequest("Ocurrio un error al obtener el listado de marcas");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GridMarca(string nombre = null, string apellido = null, string dni = null)
        {
            MarcaService empleadoService = new MarcaService(_logger);
            var model = new List<MarcaViewModel>();
            await Task.Run(() => model = empleadoService.GetAll(nombre));
            return PartialView("_GridIndex", model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MarcaViewModel marcaModel)
        {
            try
            {
                MarcaService marcaService = new MarcaService(_logger);
                marcaService.Create(marcaModel);
                SetTempData("Marca Creada.");
                _logger.LogInformation("Marca Creada correctamente");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError("Ocurrio un error al crear la marca. Error {0}", e);
                return BadRequest("Ocurrio un error al crear la marca");
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                MarcaService marcaService = new MarcaService(_logger);
                var model = marcaService.GetById(id);
                _logger.LogInformation("Marca obtenida para el Id: <{0}>", id);
                return View(model);
            }
            catch (Exception e)
            {
                _logger.LogError("No se pudo obtener la marca para el Id: <{0}>", id);
                return BadRequest("Ocurrio un error al obtener la marca");
            }
        }
        [HttpPost]
        public IActionResult Edit(MarcaViewModel modelMarca)
        {
            try
            {
                MarcaService marcaService = new MarcaService(_logger);
                marcaService.Edit(modelMarca);
                SetTempData("Marca Editada.");
                _logger.LogInformation("Marca Editada Correctamente");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError("No se pudo editar la marca. Error <{0}>", e);
                return BadRequest("Ocurrio un error al editar la marca");
            }
        }

        public IActionResult Delete (int id)
        {
            try
            {
                MarcaService marcaService = new MarcaService(_logger);
                marcaService.Delete(id);
                SetTempData("Marca Eliminada.");
                _logger.LogInformation("Marca eliminada correctamente");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError("No se pudo eliminar la marca para el Id: <{0}>. Error {1}", id, e);
                return BadRequest("Ocurrio un error al eliminar la marca");
            }
        }
        public IActionResult ValidarMarca (string nombre)
        {
            MarcaService marcaService = new MarcaService(_logger);
            var exist = marcaService.ValidarMarca(nombre);
            return Json(exist);
        }
    }
}