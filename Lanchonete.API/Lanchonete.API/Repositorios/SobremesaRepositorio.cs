using Lanchonete.API.Data.Context;
using Lanchonete.API.Models;
using Lanchonete.API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lanchonete.API.Repositorios
{    
    public class SobremesaRepositorio : ISobremesaRepositorio
    { 
        private readonly AppDbContext _context;
        public SobremesaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sobremesa> Sobremesas =>_context.Sobremesas
            .Include(c => c.Categoria);

        public Sobremesa GetLancheById(int id)
        {
            return _context.Sobremesas.FirstOrDefault(b => b.Id == id);
        }
        
    }
}
