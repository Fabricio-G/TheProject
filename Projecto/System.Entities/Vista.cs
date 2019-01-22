using System.Collections.Generic;
using Newtonsoft.Json;
using System.Entities.Repository.Interface;

namespace System.Entities
{
    public class Vista : IEntity
    {
        public int VistaId { set; get; }
        public string Descripcion { set; get; }
        public string Nombre { set; get; }
        [JsonIgnore]
        public virtual ICollection<Permiso> Permisos { set; get; }
    }
}
