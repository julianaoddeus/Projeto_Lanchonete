using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.Repositorios.Interfaces
{
    public interface ISobremesaRepositorio
    {
        IEnumerable<Sobremesa> Sobremesas { get; }        
        Sobremesa GetLancheById(int id);
    }
}
