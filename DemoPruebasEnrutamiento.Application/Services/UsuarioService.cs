using DemoPruebasEnrutamiento.Application.Interface;
using DemoPruebasEnrutamiento.Domain.Entities;

namespace DemoPruebasEnrutamiento.Application.Services
{
    public class UsuarioService(IUsuarioRepository repository) : IUsuarioService
    {
        private readonly IUsuarioRepository _repository = repository;

        public async Task<IEnumerable<Usuario>> ObtenerTodos()
            => await _repository.GetAllAsync();

        public async Task Crear(Usuario usuario)
            => await _repository.AddAsync(usuario);
    }
}
