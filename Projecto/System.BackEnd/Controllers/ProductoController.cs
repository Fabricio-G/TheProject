using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Services;
using System.Services.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace System.Backend.Controllers
{
    public class ProductoController : CommonController
    {
        private readonly ILogger<ProductoController> _logger;
        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ProductoService productoService = new ProductoService(_logger);
            var model = productoService.GetAll();
            return View(model);

        }
        public IActionResult Create()
        {
            MarcaService marcaService = new MarcaService(_logger);
            ViewData["Marca"] = marcaService.GetMarcaDropDown();
            CategoriaService categoriaService = new CategoriaService(_logger);
            ViewData["Categoria"] = categoriaService.GetCategoriaDropDown();

            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductoViewModel productoModel)
        {
            ProductoService productoService = new ProductoService(_logger);
            productoService.Create(productoModel);
            SetTempData("Producto Creada.");
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            try
            {
                ProductoService productoService = new ProductoService(_logger);
                productoService.Delete(id);
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


    }
}
