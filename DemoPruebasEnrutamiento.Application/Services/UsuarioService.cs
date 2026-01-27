using DemoPruebasEnrutamiento.Application.Interface;
using DemoPruebasEnrutamiento.Domain.Entities;

namespace DemoPruebasEnrutamiento.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Usuario>> ObtenerTodos()
            => await _repository.GetAllAsync();

        public async Task<Usuario> ObtenerPorId(int id)
            => await _repository.GetByIdAsync(id);

        public async Task Crear(Usuario usuario)
            => await _repository.AddAsync(usuario);

        public async Task Actualizar(Usuario usuario)
            => await _repository.UpdateAsync(usuario);

        public async Task Eliminar(int id)
            => await _repository.DeleteAsync(id);
    }
}
