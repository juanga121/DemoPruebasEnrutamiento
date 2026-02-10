using DemoPruebasEnrutamiento.Domain.Entities;

namespace DemoPruebasEnrutamiento.Application.Interface
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ObtenerTodos();
        Task Crear(Usuario usuario);
    }
}
