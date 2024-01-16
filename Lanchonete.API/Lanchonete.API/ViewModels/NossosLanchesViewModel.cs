using Lanchonete.API.Models;

namespace Lanchonete.API.ViewModels
{
    public class NossosLanchesViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
