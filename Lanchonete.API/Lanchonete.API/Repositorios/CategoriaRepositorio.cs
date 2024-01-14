using Lanchonete.API.Data.Context;
using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;

namespace Lanchonete.API.Repositorios
{
    public class CategoriaRepositorio : ICategoriaDeRepositorio
    {
        private readonly AppDbContext _context;
        public CategoriaRepositorio(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
