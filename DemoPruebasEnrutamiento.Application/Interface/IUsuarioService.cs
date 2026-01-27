using DemoPruebasEnrutamiento.Domain.Entities;

namespace DemoPruebasEnrutamiento.Application.Interface
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ObtenerTodos();
        Task<Usuario> ObtenerPorId(int id);
        Task Crear(Usuario usuario);
        Task Actualizar(Usuario usuario);
        Task Eliminar(int id);
    }
}
