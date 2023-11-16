public interface ITableroRepositorio{
    public Tablero CrearTablero();
    public Tablero ModificarTablero(int idTablero);
    public Tablero DetallesTablero(int idTablero);
    public List<Tablero> ListarTableros();
    public List<Tablero> ListarTablerosPorUsuario(int idUsuario);
    public void EliminarTablero(int idTablero);
}