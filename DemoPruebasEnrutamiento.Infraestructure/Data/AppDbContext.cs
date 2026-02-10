using DemoPruebasEnrutamiento.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoPruebasEnrutamiento.Infraestructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Usuario> Usuario { get; set; }
    }
}
