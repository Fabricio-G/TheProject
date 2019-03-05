﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Entities;
using System.Text;
using System.Linq;
using System.Services.Models;

namespace System.Services
{
    public class EmpleadoService
    {
        private readonly ILogger _logger;
        readonly UnitOfWork _uow = new UnitOfWork();

        public EmpleadoService(ILogger logger)
        {
            _logger = logger;
        }
        public List<EmpleadoViewModel> GetAll()
        {
            var model = _uow.EmpleadoRepository.All();
            var empleado = new List<EmpleadoViewModel>();
            foreach (var emp in model)
            {
                empleado.Add(new EmpleadoViewModel
                {
                    Apellido = emp.Apellido,
                    DNI = emp.DNI,
                    Domicilio = emp.Domicilio,
                    JornadasTrabajadas = emp.JornadasTrabajadas,
                    Nombre = emp.Nombre,
                    Sueldo = emp.Sueldo,
                    Telefono = emp.Telefono
                });
            }
            return empleado;
        }
        public EmpleadoViewModel GetById (int id)
        {
            var model = _uow.EmpleadoRepository.Find(x => x.EmpleadoId == id);
            return new EmpleadoViewModel
            {
                EmpleadoId = model.EmpleadoId,
                Apellido = model.Apellido,
                DNI = model.DNI,
                Domicilio = model.Domicilio,
                JornadasTrabajadas = model.JornadasTrabajadas,
                Nombre = model.Nombre,
                Sueldo = model.Sueldo,
                Telefono = model.Telefono
            };
        }
        public void Create (EmpleadoViewModel model)
        {
            var empleado = new Empleado
            {
                Apellido = model.Apellido,
                Telefono = model.Telefono,
                DNI = model.DNI,
                Domicilio = model.Domicilio,
                EmpleadoId = model.EmpleadoId,
                JornadasTrabajadas = model.JornadasTrabajadas,
                Nombre = model.Nombre,
                Sueldo = model.Sueldo
            };
            _uow.EmpleadoRepository.Create(empleado);
            _uow.EmpleadoRepository.Save();
        }
    }
}
