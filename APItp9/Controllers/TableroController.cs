using kanban;
using Microsoft.AspNetCore.Mvc;

namespace kanban.controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TableroControllers : ControllerBase{

        private ITableroRepositorio TableroRepositorio;
        private readonly ILogger<UsuarioController> _logger;
        
        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
            tableroRepositorio = new tableroRepositorio();
        }
        
        [HttpGet]
        public List<Tablero> obtenerTableros(){
            return tableroRepositorio.ListarTableros();
        }

        [HttpGet]
        [Route("api/tableros/usuario/{id}")]
        public List<Tablero> obtenerTablero(int id){
            return tableroRepositorio.ListarTablerosPorUsuario(id);
        }

        [HttpPost]
        [Route("api/tableros/agregar")]
        public IActionResult agregarTablero(Tablero tablero){
            tableroRepositorio.CrearTablero(tablero);
            return Ok("Tablero creado con exito!");
        }

        [HttpPut]
        [Route("api/tableros/actualizar")]
        public  IActionResult actualizarTablero(int id, Tablero tablero){
            tableroRepositorio.ModificarTablero(id, tablero);
            return Ok("Tablero modificado");
        }     

        [HttpDelete]
        [Route("api/tableros/eliminar")]
        public IActionResult eliminarTablero(int idTablero){
            tableroRepositorio.EliminarTablero(idTablero);
            return Ok("Tablero eliminado");
        }
    }

}