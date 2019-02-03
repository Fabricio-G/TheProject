﻿using Microsoft.Extensions.Logging;
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
        public CategoriaViewModel GetById(int id)
        {
            var model = _uow.CategoriaRepository.Find(x => x.CategoriaId == id);
            var categoria = new CategoriaViewModel()
            {
                CategoriaId = model.CategoriaId,
                Nombre = model.Nombre
            };
            return categoria;
        }

        public void Create(CategoriaViewModel model)
        {
            var categoria = new Categoria()
            {
                Nombre = model.Nombre
            };
            _uow.CategoriaRepository.Create(categoria);
            _uow.CategoriaRepository.Save();
        }

        public void Edit(CategoriaViewModel model)
        {
            var categoria = _uow.CategoriaRepository.Find(x => x.CategoriaId == model.CategoriaId);
            categoria.Nombre = model.Nombre;
            _uow.CategoriaRepository.Update(categoria);
            _uow.CategoriaRepository.Save();
        }

        public void Delete(int categoriaId)
        {
            var categoria = _uow.CategoriaRepository.Find(x => x.CategoriaId == categoriaId);
            _uow.CategoriaRepository.Delete(categoria);
            _uow.CategoriaRepository.Save();
        }
    }
}
