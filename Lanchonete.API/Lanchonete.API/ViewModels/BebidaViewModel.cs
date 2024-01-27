using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.ViewModels
{
    public class BebidaViewModel
    {
        public IEnumerable<Bebida> Bebidas { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
