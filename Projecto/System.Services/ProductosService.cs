using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Entities;
using System.Services.Models;
using System.Text;

namespace System.Services
{
    public class ProductosService
    {
        private readonly ILogger _logger;   
        readonly UnitOfWork _uow = new UnitOfWork();

        public ProductosService(ILogger logger)
        {
            _logger = logger;
        }

        public List<ProductosModel> GetAll()
        {
            var model = _uow.MarcaRepository.All();
            var marca = new List<ProductosModel>();
            foreach (var value in model)
            {
                marca.Add(new ProductosModel { ProductosId = value.MarcaId, Nombre = value.Nombre });
            }
            return marca;
        }


    }
}
