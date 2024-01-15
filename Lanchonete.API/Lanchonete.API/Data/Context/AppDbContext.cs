using Lanchonete.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.API.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }       

    }
}
