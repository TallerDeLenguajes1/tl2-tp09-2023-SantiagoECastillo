using TODO.Models;
public interface ITareaRepositorio{
    public Tarea CrearTarea(int idTablero);
    public void ModificarTarea(int idTarea, Tarea tarea);
    public Tarea DetallesTarea(int idTarea);
    public List<Tarea> ListarTareasUsuario(int idUsuario);
    public List<Tarea> ListarTareasTablero(int idTablero);
    public void EliminarTarea(int idTarea);
    public void AsignarUsuarioATarea(int idUsuario, int idTarea);
}