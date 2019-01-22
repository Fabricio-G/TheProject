using Newtonsoft.Json;
using System.Entities.Repository.Interface;

namespace System.Entities
{
    public class RolPermiso : IEntity
    {
        public int PermisoId { set; get; }
        [JsonIgnore]
        public virtual Permiso Permiso { set; get; }
        public int RolId { set; get; }
        [JsonIgnore]
        public virtual Rol Rol { get; set; }
    }
}
