using Lanchonete.API.Data.Context;
using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.API.Repositorios
{
    public class LancheRepositorio : ILancheRepositorio
    {
        private readonly AppDbContext _context;
        public LancheRepositorio(AppDbContext context)
        {
            _context = context;
        }     
        public IEnumerable<Lanche> Lanches => _context.Lanches
            .Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
            .Where(w => w.EhLanchePreferido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
           return  _context.Lanches.FirstOrDefault(f => f.Id == id);       
        }
    }
}
