using Lanchonete.API.Data.Context;
using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using System.Collections.Generic;

namespace Lanchonete.API.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly AppDbContext _context;
        public CategoriaRepositorio(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
