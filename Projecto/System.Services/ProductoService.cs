using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Entities;
using System.Services.Models;
using System.Text;

namespace System.Services
{
    public class ProductoService
    {
        private readonly ILogger _logger;   
        readonly UnitOfWork _uow = new UnitOfWork();

        public ProductoService(ILogger logger)
        {
            _logger = logger;
        }

        public List<ProductoModel> GetAll()
        {
            var model = _uow.ProductoRepository.All();
            var producto = new List<ProductoModel>();
            foreach (var value in model)
            {
                producto.Add(new ProductoModel { ProductoId = value.ProductoId, Nombre = value.Nombre, Descripcion = value.Descripcion });
            }
            return producto;
        }
        public void Create(ProductoViewModel model)
        {
            var producto = new Producto()
            {
                Nombre = model.Nombre
            };
            _uow.ProductoRepository.Create(producto);
            _uow.ProductoRepository.Save();
        }

    }
}
