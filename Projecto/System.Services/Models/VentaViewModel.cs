using System;
using System.Collections.Generic;
using System.Text;

namespace System.Services.Models
{
    public class VentaViewModel
    {
        public string Monto { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int ProductoId { get; set; }
    }
}
