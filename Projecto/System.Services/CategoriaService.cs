using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Entities;
using System.Services.Models;
using System.Text;

namespace System.Services
{
    public class CategoriaService
    {
        private readonly ILogger _logger;
        readonly UnitOfWork _uow = new UnitOfWork();

        public CategoriaService(ILogger logger)
        {
            _logger = logger;
        }

        public List<CategoriaViewModel> GetAll()
        {
            var model = _uow.CategoriaRepository.All();
            var categoria = new List<CategoriaViewModel>();
            foreach (var cat in model)
            {
                categoria.Add(new CategoriaViewModel { CategoriaId = cat.CategoriaId, Nombre = cat.Nombre });
            }
            return categoria;
        }
    }
}
