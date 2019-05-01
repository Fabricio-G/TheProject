using System;
using System.Collections.Generic;
using System.Linq;
using System.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace System.Backend.Controllers
{
    public class VentaController : CommonController
    {
        private readonly ILogger<VentaController> _logger;
        public VentaController(ILogger<VentaController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            MarcaService ms = new MarcaService(_logger);
            CategoriaService cs = new CategoriaService(_logger);
            ViewData["Marcas"] = ms.GetMarcaDropDown();
            ViewData["Categorias"] = cs.GetCategoriaDropDown();
            return View();
        }
        public JsonResult GetProductos(int categoriaId, int marcaId)
        {
            VentaService vs = new VentaService(_logger);
            return Json(new SelectList(vs.GetProductosList(categoriaId, marcaId), "ProductoId", "Nombre"));
        }
        public IActionResult GetDataProducto(int productoId)
        {
            ProductoService ps = new ProductoService(_logger);
            var model = ps.GetById(productoId);
            return Json(new { nombre = model.Nombre, monto = model.Precio });
        }
    }
}