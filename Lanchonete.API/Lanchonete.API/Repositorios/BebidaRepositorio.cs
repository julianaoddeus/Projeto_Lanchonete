using Lanchonete.API.Data.Context;
using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Repositorios
{    
    public class BebidaRepositorio : IBebidaRepositorio
    { 
        private readonly AppDbContext _context;
        public BebidaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bebida> Bebidas =>_context.Bebidas
            .Include(c => c.Categoria);

        public Bebida GetLancheById(int id)
        {
            return _context.Bebidas.FirstOrDefault(b => b.Id == id);
        }
        
    }
}
