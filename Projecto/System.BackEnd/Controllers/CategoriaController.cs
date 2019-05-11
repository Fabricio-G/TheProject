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
    public class CategoriaController : CommonController
    {
        private readonly ILogger<CategoriaController> _logger;
        public CategoriaController(ILogger<CategoriaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            try
            {
                CategoriaService categoriaService = new CategoriaService(_logger);
                var model = categoriaService.GetAll();
                _logger.LogInformation("Listado de categorias obtenido correctamente");
                return View(model);
            }
            catch (Exception e)
            {
                _logger.LogError("Ocurrio un error al obtener el listado de categorias. Error {0}", e);
                return BadRequest("Ocurrio un error al obtener el listado de categorias");
            }
        }
        [HttpGet]
        public async Task<IActionResult> GridCategorias(string nombre = null)
        {
            CategoriaService categoriaService = new CategoriaService(_logger);
            var model = new List<CategoriaViewModel>();
            await Task.Run(() => model = categoriaService.GetAll(nombre));
            return PartialView("_GridIndex", model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoriaViewModel categoriaModel)
        {
            try
            {
                CategoriaService categoriaService = new CategoriaService(_logger);
                categoriaService.Create(categoriaModel);
                SetTempData("Categoria Creada.");
                _logger.LogInformation("Categoria Creada correctamente");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError("Ocurrio un error al crear la Categoria. Error {0}", e);
                return BadRequest("Ocurrio un error al crear la Categoria");
            }
        }

        public IActionResult Edit(int id)
        {
            try
            {
                CategoriaService categoriaService = new CategoriaService(_logger);
                var model = categoriaService.GetById(id);
                _logger.LogInformation("Categoria obtenida para el Id: <{0}>", id);
                return View(model);
            }
            catch (Exception e)
            {
                _logger.LogError("No se pudo obtener la Categoria para el Id: <{0}>", id);
                return BadRequest("Ocurrio un error al obtener la Categoria");
            }
        }
        [HttpPost]
        public IActionResult Edit(CategoriaViewModel categoriaModel)
        {
            try
            {
                CategoriaService categoriaService = new CategoriaService(_logger);
                categoriaService.Edit(categoriaModel);
                SetTempData("Categoria Editada.");
                _logger.LogInformation("Categoria Editada Correctamente");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError("No se pudo editar la Categoria. Error <{0}>", e);
                return BadRequest("Ocurrio un error al editar la Categoria");
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                CategoriaService categoriaService = new CategoriaService(_logger);
                categoriaService.Delete(id);
                SetTempData("Categoria Eliminada.");
                _logger.LogInformation("Categoria eliminada correctamente");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError("No se pudo eliminar la Categoria para el Id: <{0}>. Error {1}", id, e);
                return BadRequest("Ocurrio un error al eliminar la Categoria");
            }
        }
        public IActionResult ValidarCategoria(string nombre)
        {
            CategoriaService marcaService = new CategoriaService(_logger);
            var exist = marcaService.ValidarCategoria(nombre);
            return Json(exist);
        }
    }
}