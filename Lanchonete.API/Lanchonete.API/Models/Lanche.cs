using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete.API.Models
{    
    public class Lanche : Produto
    {
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Deve ter no mínimo {0} caracteres e no máximo {1}")]
        [Required(ErrorMessage = "Informe descricao da categoria")]
        [Display(Name = "Descricao")]
        public string DescricaoReduzida { get; set; }

        [Display(Name = "Preferido?")]
        public bool EhLanchePreferido { get; set; }
    }
}
