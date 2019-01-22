using System;
using System.Collections.Generic;
using System.Entities.Repository.Interface;
using System.Text;

namespace System.Entities
{
    public class Producto: IEntity
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public string Imagen { get; set; }
        public string BreveDescripcion { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
    }
}
