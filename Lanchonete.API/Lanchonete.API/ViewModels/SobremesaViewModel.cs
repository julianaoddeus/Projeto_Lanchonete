using Lanchonete.API.Models;
using System.Collections.Generic;

namespace Lanchonete.API.ViewModels
{
    public class SobremesaViewModel
    {
        public IEnumerable<Sobremesa> Sobremesas { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
