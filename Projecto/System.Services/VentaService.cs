using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Entities;
using System.Linq;
using System.Text;

namespace System.Services
{
    public class VentaService
    {
        private readonly ILogger _logger;
        readonly UnitOfWork _uow = new UnitOfWork();

        public VentaService(ILogger logger)
        {
            _logger = logger;
        }

        public IEnumerable GetProductosList (int categoriaId, int marcaId)
        {
            try
            {
                return _uow.ProductoRepository.Filter(x => x.CategoriaId == categoriaId && x.MarcaId == marcaId).OrderBy(x => x.Nombre).ToList();
            }
            catch
            {
                return new List<Producto>();
            }
        }
    }
}
