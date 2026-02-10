using DemoPruebasEnrutamiento.Application.Interface;
using DemoPruebasEnrutamiento.Domain.Entities;
using DemoPruebasEnrutamiento.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoPruebasEnrutamiento.Infraestructure.Repositories
{
    public class UsuarioRepository(AppDbContext context) : IUsuarioRepository
    {
        private readonly AppDbContext _context = context;

        public async Task<IEnumerable<Usuario>> GetAllAsync()
            => await _context.Usuario.ToListAsync();

        public async Task AddAsync(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
