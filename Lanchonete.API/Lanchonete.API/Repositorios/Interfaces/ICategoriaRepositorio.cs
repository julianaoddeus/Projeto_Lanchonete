using Lanchonete.API.Data.Context;
using Lanchonete.API.Models;

namespace Lanchonete.API.Repositorios.Interfaces
{
    public interface ICategoriaDeRepositorio
    {
        IEnumerable<Categoria> Categorias { get;}
        
    }
}
