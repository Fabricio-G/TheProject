using System;
using System.Collections.Generic;
using System.Entities.Repository.Interface;
using System.Text;

namespace System.Entities
{
    public class Categoria : IEntity
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
