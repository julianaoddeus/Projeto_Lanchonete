using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.Repositorios.Interfaces
{
    public interface ILancheRepositorio
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int id);
    }
}
