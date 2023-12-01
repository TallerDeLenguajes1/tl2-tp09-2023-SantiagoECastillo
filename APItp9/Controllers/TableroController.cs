using TODO.Models;
using TODO.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace kanban.controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TableroControllers : ControllerBase{

        private ITableroRepositorio tableroRepositorio;
        private readonly ILogger<TableroControllers> _logger;
        
        public TableroControllers(ILogger<TableroControllers> logger)
        {
            _logger = logger;
            tableroRepositorio = new TableroRepositorio();
        }
        
        [HttpGet]
        public List<Tablero> ObtenerTableros(){
            return tableroRepositorio.ListarTableros();
        }

        [HttpGet]
        [Route("api/tableros/usuario/{id}")]
        public List<Tablero> ObtenerTablero(int id){
            return tableroRepositorio.ListarTablerosPorUsuario(id);
        }

        [HttpPost]
        [Route("api/tableros/agregar")]
        public IActionResult AgregarTablero(Tablero tablero){
            tableroRepositorio.CrearTablero(tablero);
            return Ok("Tablero creado con exito!");
        }

        [HttpPut]
        [Route("api/tableros/actualizar")]
        public  IActionResult ActualizarTablero(int id, Tablero tablero){
            tableroRepositorio.ModificarTablero(id, tablero);
            return Ok("Tablero modificado");
        }     

        [HttpDelete]
        [Route("api/tableros/eliminar")]
        public IActionResult EliminarTablero(int idTablero){
            tableroRepositorio.EliminarTablero(idTablero);
            return Ok("Tablero eliminado");
        }
    }

}