public interface IUsuarioRepositorio{
    public void CrearUsuario(Usuario nuevoUsuario);
    public Usuario ModificarUsuario(Usuario usuario);
    public List<Usuario> ObtenerTodosUsuarios();

    public Usuario DetallesUsuarios(int idUsuario);
    public void EliminarUsuarios(int idUsuario);

}