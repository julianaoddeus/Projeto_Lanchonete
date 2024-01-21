using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lanchonete.API.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres.")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres.")]
        [Required(ErrorMessage = "Informe descricao da categoria")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        //definindo a relação de um para um
        public List<Lanche> Lanches { get; set; }
    }
}
