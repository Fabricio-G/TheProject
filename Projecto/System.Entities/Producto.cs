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
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
