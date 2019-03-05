using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace System.Services.Models
{
    public class EmpleadoViewModel
    {
        public int EmpleadoId { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Domicilio es obligatorio")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        public int DNI { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public int Telefono { get; set; }
        public int Sueldo { get; set; }
        public string JornadasTrabajadas { get; set; }
    }
}
