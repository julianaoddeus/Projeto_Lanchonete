using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.Repositorios.Interfaces
{
    public interface IBebidaRepositorio
    {
        IEnumerable<Bebida> Bebidas { get; }      
        Bebida GetLancheById(int id);
    }
}
