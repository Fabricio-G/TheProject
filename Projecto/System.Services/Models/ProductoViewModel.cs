using System;
using System.Collections.Generic;
using System.Text;

namespace System.Services.Models
{
    public class ProductoViewModel
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int Codigo { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public string BreveDescripcion { get; set; }
        public string Descripcion { get; set; }

    }
}
