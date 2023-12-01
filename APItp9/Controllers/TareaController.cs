using TODO.Models;
using TODO.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace TODO.controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TareaControllers : ControllerBase{

        private ITareaRepositorio tareaRepositorio;
        private readonly ILogger<TareaControllers> _logger;
        
        public TareaControllers(ILogger<TareaControllers> logger)
        {
            _logger = logger;
            tareaRepositorio = new TareasRepositorio();
        }
        
        [HttpGet]
        [Route("api/tarea/tablero")]
        public List<Tarea> ObtenerTareaPorTablero(int idTablero){
            return tareaRepositorio.ListarTareasTablero(idTablero);
        }

        [HttpGet]
        [Route("api/tarea/usuario")]
        public List<Tarea> ObtenerTareaPorUsuario(int idUsuario){
            return tareaRepositorio.ListarTareasUsuario(idUsuario);
        }

        [HttpPost]
        [Route("api/tarea/agregar")]
        public IActionResult AgregarTarea(int idTablero, Tarea tarea){
            tareaRepositorio.CrearTarea(idTablero, tarea);
            return Ok("Tablero creado con exito!");
        }

        [HttpPut]
        [Route("api/tarea/modificar")]
        public  IActionResult ActualizarTarea(int id, Tarea tarea){
            tareaRepositorio.ModificarTarea(id, tarea);
            return Ok("Tarea modificado");
        }    
        
        [HttpPut]
        [Route("api/tarea/modificarEstado")]
        public  IActionResult ActualizarEstadoTarea(int id, EstadoTarea estadoTarea){
            var tarea = tareaRepositorio.ObtenerTarea(id);
            tarea.Estado1 = estadoTarea;
            tareaRepositorio.ModificarTarea(id, tarea);
            return Ok("Estado Modificado");
        }   

        [HttpPut]
        [Route("api/tarea/asginarTarea")]
        public  IActionResult AsignarTarea(int idUsuario, int idTarea){
            tareaRepositorio.AsignarUsuarioATarea(idUsuario, idTarea);
            return Ok("Tarea asginada al usuario");
        }     

        [HttpDelete]
        [Route("api/tarea/eliminar")]
        public IActionResult EliminarTarea(int idTarea){
            tareaRepositorio.EliminarTarea(idTarea);
            return Ok("Tarea eliminada");
        }
    }

}