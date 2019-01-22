using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Entities.Repository.Interface;

namespace System.Entities
{
	public interface IUnitOfWork
	{
		IRepository<Auditoria> AuditoriaRepository {get;}
		IRepository<Parametro> ParametroRepository {get;}
		IRepository<Permiso> PermisoRepository {get;}
		IRepository<Rol> RolRepository {get;}
		IRepository<RolPermiso> RolPermisoRepository {get;}
		IRepository<Usuario> UsuarioRepository {get;}
        IRepository<UsuarioToken> UsuarioTokenRepository { get; }
        IRepository<UsuarioRol> UsuarioRolRepository {get;}
		IRepository<Vista> VistaRepository {get;}
        IRepository<Producto> ProductoRepository { get; }
        IRepository<Categoria> CategoriaRepository { get; }
        IRepository<Marca> MarcaRepository { get; }
				int Save();
	}
}