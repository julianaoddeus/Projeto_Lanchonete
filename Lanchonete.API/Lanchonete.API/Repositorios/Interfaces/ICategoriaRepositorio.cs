using Lanchonete.API.Data.Context;
using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.Repositorios.Interfaces
{
    public interface ICategoriaRepositorio
    {
        IEnumerable<Categoria> Categorias { get;}
        
    }
}
