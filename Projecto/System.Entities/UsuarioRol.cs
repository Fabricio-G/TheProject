using Newtonsoft.Json;
using System.Entities.Repository.Interface;

namespace System.Entities
{
    public class UsuarioRol : IEntity
    {
        public int UsuarioId { get; set; }
        [JsonIgnore]
        public virtual Usuario Usuario { get; set; }
        public int RolId { get; set; }
        [JsonIgnore]
        public virtual Rol Rol { get; set; }
    }
}
