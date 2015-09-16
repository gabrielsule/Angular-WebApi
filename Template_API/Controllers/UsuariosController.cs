using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Template_API.Models;
using Mega.produccion_BLL;
using Mega.produccion.Models.DomainEntities;

namespace Template_API.Controllers
{

    [RoutePrefix("api/Usuarios")]
        
    public class UsuariosController : ApiController
    {
        static readonly UsuariosLogic bllNovedades = new UsuariosLogic();
        [HttpGet]
        public IEnumerable<UsuarioModel> GetAllUsuarios()
        {
            return MapTolist(bllNovedades.GetUsuarios());
        }

        private static List<UsuarioModel> MapTolist(IList<Usuario> usuariosFromBLL)
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            foreach (Usuario current in usuariosFromBLL)
            {
                lista.Add(new UsuarioModel { Id = current.Id, UserName = current.UserName, Apellido = current.Apellido, eMail = current.eMail, Nombre = current.Nombre });
            }
            return lista;
        }

        [HttpPost]
        [Route("AddUsuario")]
        public bool AddUsuario(UsuarioModel usuario)
        {
            Usuario usuarioEntity = new Usuario { UserName = usuario.UserName, Nombre = usuario.Nombre, Apellido = usuario.Apellido, eMail = usuario.eMail };

            bllNovedades.AltaUsuario(usuarioEntity);
            var response = Request.CreateResponse<Usuario>(HttpStatusCode.Created, usuarioEntity);
            return true;
        }
    }
}