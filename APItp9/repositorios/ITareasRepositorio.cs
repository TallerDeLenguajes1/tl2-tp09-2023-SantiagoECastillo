public interface ITareaRepositorio{
    public Tareas CrearTarea(int idTablero);
    public void ModificarTarea(int idTarea, Tareas tarea);
    public Tareas DetallesTarea(int idTarea);
    public List<Tareas> ListarTareasUsuario(int idUsuario);
    public List<Tareas> ListarTareasTablero(int idTablero);
    public void EliminarTarea(int idTarea);
    public void AsignarUsuarioATarea(int idUsuario, int idTarea);
}