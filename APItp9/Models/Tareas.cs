
public class Tarea{
    private int idTarea;
    private string? nombreTarea;
    private string? descripcionTarea;
    private string? color;
    private EstadoTarea Estado;
    private int? IdUsuarioAsignado;

}

public enum EstadoTarea{
    Ideas,
    ToDo, 
    Doing, 
    Review, 
    Done

}