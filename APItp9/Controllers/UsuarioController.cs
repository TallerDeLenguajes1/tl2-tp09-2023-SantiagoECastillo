using kanban;
using Microsoft.AspNetCore.Mvc;

namespace kanban.controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControllers : ControllerBase{

        private IUsuarioRepositorio usuarioRepositorio;
        private readonly ILogger<UsuarioController> _logger;
        
        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
            usuarioRepositorio = new usuarioRepositorio();
        }
        
        [HttpGet]
        public List<Usuario> obtenerUsuarios(){
            return usuarioRepositorio.ObtenerTodosUsuarios();
        }

        [HttpGet]
        [Route("api/usuarios/{id}")]
        public Usuario obtener(){
            return usuarioRepositorio.ObtenerUsuarioPorId();
        }

        [HttpPost]
        [Route("api/usuarios/agregar")]
        public IActionResult agregarUsuario(){
            usuarioRepositorio.CrearUsuario(usuario);
            return Ok("Usuario creado con exito!");
        }

        [HttpPut]
        [Route("api/usuario/actualizar")]
        public  IActionResult actualizarUsuario(){
            usuarioRepositorio.ModificarUsuario();
            return Ok("Usuario modificado");
        }     

        
    }

}