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

        public List<ProductoViewModel> GetAll()
        {
            var model = _uow.ProductoRepository.All();
            var producto = new List<ProductoViewModel>();
            foreach (var value in model)
            {
                producto.Add(new ProductoViewModel { ProductoId = value.ProductoId, Nombre = value.Nombre, BreveDescripcion = value.BreveDescripcion, Precio = value.Precio, Estado =value.Estado });
            }
            return producto;
        }
        public void Create(ProductoViewModel model)
        {
            var producto = new Producto()
            {
                Nombre = model.Nombre,
                CategoriaId = model.CategoriaId,
                MarcaId = model.MarcaId,
                BreveDescripcion = model.BreveDescripcion,
                Cantidad = model.Cantidad,
                Codigo = model.Codigo,
                Estado = model.Estado,
                Descripcion = model.Descripcion,
                Precio = model.Precio
            };
            _uow.ProductoRepository.Create(producto);
            _uow.ProductoRepository.Save();
        }
        public void Delete(int productoId)
        {
            var producto = _uow.ProductoRepository.Find(x => x.ProductoId == productoId);
            _uow.ProductoRepository.Delete(producto);
            _uow.ProductoRepository.Save();
        }

        public ProductoViewModel GetById(int id)
        {
            var model = _uow.ProductoRepository.Find(x => x.ProductoId == id);
            var producto = new ProductoViewModel()
            {
                ProductoId = model.ProductoId,
                Nombre = model.Nombre,
                CategoriaId = model.CategoriaId,
                MarcaId = model.MarcaId,
                BreveDescripcion = model.BreveDescripcion,
                Cantidad = model.Cantidad,
                Codigo = model.Codigo,
                Estado = model.Estado,
                Descripcion = model.Descripcion,
                Precio = model.Precio
            };
            return producto;
        }
        public void Edit(ProductoViewModel model)
        {
            var producto = _uow.ProductoRepository.Find(x => x.ProductoId == model.ProductoId);
            producto.ProductoId = model.ProductoId;
            producto.Nombre = model.Nombre;
            producto.CategoriaId = model.CategoriaId;
            producto.MarcaId = model.MarcaId;
            producto.BreveDescripcion = model.BreveDescripcion;
            producto.Cantidad = model.Cantidad;
            producto.Codigo = model.Codigo;
            producto.Estado = model.Estado;
            producto.Descripcion = model.Descripcion;
            producto.Precio = model.Precio;

            _uow.ProductoRepository.Update(producto);
            _uow.ProductoRepository.Save();
        }

    }
}
