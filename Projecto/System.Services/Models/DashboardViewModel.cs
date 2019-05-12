using System;
using System.Collections.Generic;
using System.Text;

namespace System.Services.Models
{
    public class DashboardViewModel
    {
        public List<CategoriaModel> Categorias { get; set; }
        public List<MarcaModel> Marcas { get; set; }
        public List<string> ProductosSinStock { get; set; }
        public List<string> ProductosPorAgotar { get; set; }
        public class CategoriaModel
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
        }
        public class MarcaModel
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
        }
    }
   
}
