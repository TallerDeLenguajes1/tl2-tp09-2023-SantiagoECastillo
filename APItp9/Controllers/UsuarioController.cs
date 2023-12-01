using Microsoft.AspNetCore.Mvc;
using TODO.Models;
using TODO.Repositorio;

namespace TODO.controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControllers : ControllerBase{

        private IUsuarioRepositorio usuarioRepositorio;
        private readonly ILogger<UsuarioControllers> _logger;
        
        public UsuarioControllers(ILogger<UsuarioControllers> logger)
        {
            _logger = logger;
            usuarioRepositorio = new UsuarioRepositorio();
        }
        
        [HttpGet]
        public List<Usuario> ObtenerUsuarios(){
            return usuarioRepositorio.ObtenerTodosUsuarios();
        }

        [HttpGet]
        [Route("api/usuarios/{id}")]
        public Usuario Obtener(int idUsuario){
            return usuarioRepositorio.ObtenerUsuarioPorId(idUsuario);
        }

        [HttpPost]
        [Route("api/usuarios/agregar")]
        public IActionResult AgregarUsuario(Usuario usuario){
            usuarioRepositorio.CrearUsuario(usuario);
            return Ok("Usuario creado con exito!");
        }

        [HttpPut]
        [Route("api/usuario/actualizar")]
        public  IActionResult ActualizarUsuario(Usuario usuario){
            usuarioRepositorio.ModificarUsuario(usuario);
            return Ok("Usuario modificado");
        }        
    
    }

}