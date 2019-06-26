using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Entities.Repository.Interface;

namespace System.Entities
{
    public class Usuario : IEntity
    {
        public int UsuarioId { set; get; }
        public string Apellido { set; get; }
        public string Nombre { set; get; }
        public bool Habilitado { set; get; }
        public DateTime TSCreado { set; get; }
        public DateTime? TSModificado { set; get; }
        public DateTime? TSEliminado { set; get; }
        public string Contrasena { set; get; }
        public bool ContrasenaActualizada { get; set; }
        public string Email { set; get; }
        [JsonIgnore]
        public virtual ICollection<UsuarioRol> UsuarioRoles { get; } = new List<UsuarioRol>();
        [JsonIgnore]
        public virtual ICollection<UsuarioToken> UsuarioToken { get; }
    }
}
