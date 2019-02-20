using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Entities;
using System.Linq;
using System.Services.Models;
using System.Text;

namespace System.Services
{
    public class MarcaService
    {
        private readonly ILogger _logger;
        readonly UnitOfWork _uow = new UnitOfWork();

        public MarcaService(ILogger logger)
        {
            _logger = logger;
        }

        public List<MarcaViewModel> GetAll()
        {
            var model = _uow.MarcaRepository.All();
            var marca = new List<MarcaViewModel>();
            foreach (var value in model)
            {
                marca.Add(new MarcaViewModel { MarcaId = value.MarcaId, Nombre = value.Nombre });
            }
            return marca;
        }

        public MarcaViewModel GetById(int id)
        {
            var model = _uow.MarcaRepository.Find(x => x.MarcaId == id);
            var marca = new MarcaViewModel()
            {
                MarcaId = model.MarcaId,
                Nombre = model.Nombre
            };
            return marca;
        }

        public void Create (MarcaViewModel model)
        {
            var marca = new Marca()
            {
                Nombre = model.Nombre
            };
            _uow.MarcaRepository.Create(marca);
            _uow.MarcaRepository.Save();
        }

        public void Edit (MarcaViewModel model)
        {
            var marca = _uow.MarcaRepository.Find(x => x.MarcaId == model.MarcaId);
            marca.Nombre = model.Nombre;
            _uow.MarcaRepository.Update(marca);
            _uow.MarcaRepository.Save();
        }

        public void Delete (int marcaId)
        {
            var marca = _uow.MarcaRepository.Find(x => x.MarcaId == marcaId);
            _uow.MarcaRepository.Delete(marca);
            _uow.MarcaRepository.Save();
        }
        public bool ValidarMarca (string nombre)
        {
            return _uow.MarcaRepository.All().Any(x => x.Nombre == nombre);
        }
    }
}
