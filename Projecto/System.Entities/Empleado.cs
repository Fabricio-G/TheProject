using System;
using System.Collections.Generic;
using System.Entities.Repository.Interface;
using System.Text;

namespace System.Entities
{
    public class Empleado: IEntity
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public int DNI { get; set; }
        public string Telefono { get; set; }
        public decimal Sueldo { get; set; }
        public string JornadasTrabajadas { get; set; }
    }
}
