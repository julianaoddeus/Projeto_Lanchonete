using System.ComponentModel.DataAnnotations;

namespace Lanchonete.API.Models
{
    public class CarrinhoCompraItem
    {
        public int Id { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        
        [StringLength(200)]
        public string CarrinhoDeCompraId { get; set; }
    }
}
