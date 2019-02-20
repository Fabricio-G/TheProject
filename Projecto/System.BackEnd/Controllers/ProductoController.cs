﻿using System;
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


    }
}
