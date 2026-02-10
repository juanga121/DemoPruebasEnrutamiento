using DemoPruebasEnrutamiento.Domain.Entities;

namespace DemoPruebasEnrutamiento.Application.Interface
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task AddAsync(Usuario usuario);
    }
}
