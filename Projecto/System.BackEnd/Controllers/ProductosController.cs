using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Services;
using System.Services.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace System.Backend.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ILogger<ProductosController> _logger;
        public ProductosController(ILogger<ProductosController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ProductosService productosService = new ProductosService(_logger);
            var model = productosService.GetAll();
            return View(model);

        }
    }
}
