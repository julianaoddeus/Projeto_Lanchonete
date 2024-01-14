using Lanchonete.API.Models;

namespace Lanchonete.API.Repositorios.Interfaces
{
    public interface ILancheRepositorio
    {
        IEnumerable<Lanche> lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int id);
    }
}
