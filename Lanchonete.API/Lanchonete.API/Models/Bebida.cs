using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete.API.Models
{    
    public class Bebida
    {        
        public int Id { get; set; }
        
        [StringLength(80, MinimumLength =10, ErrorMessage ="Deve ter no mínimo {0} caracteres e no máximo {1}")]
        [Required(ErrorMessage ="O nome do lanche deve ser informado")]
        [Display(Name ="Nome do bebida")]
        public string Nome { get; set;}        

        [StringLength(200, MinimumLength = 10, ErrorMessage = "Deve ter no mínimo {0} caracteres e no máximo {1}")]
        [Required(ErrorMessage = "Informe descricao da categoria")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O Preço deve estar entre R$ 1 e R$ 999,99")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho da imagem Normal")]
        [StringLength(200, ErrorMessage = "Deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da imagem Minuatura")]
        [StringLength(200, ErrorMessage = "Deve ter no máximo {1} caracteres")]
        public string ImagemThumbmailUrl { get; set; }        

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
