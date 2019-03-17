using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace System.Services.Models
{
    public class ProductoViewModel
    {
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Categoria es obligatorio")]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "El campo Marca es obligatorio")]
        public int MarcaId { get; set; }
        [Required(ErrorMessage = "El campo Codigo es obligatorio")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "El campo Precio es obligatorio")]
        public int Precio { get; set; }
        [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "El campo Breve Descripción es obligatorio")]
        public string BreveDescripcion { get; set; }
        [Required(ErrorMessage = "El campo Descripción es obligatorio")]
        public string Descripcion { get; set; }

    }
}
