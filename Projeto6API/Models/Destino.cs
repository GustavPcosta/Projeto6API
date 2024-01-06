using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto6API.Models
{
    [Table("Destino")]
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Sobrenome { get; set; }
        [Required] public string Email { get; set; }


        [Display(Name = "Situação de pagamento")]
        public bool Pagamento { get; set; }

        [Required] public string Cep { get; set; }
        [Required] public string Estado { get; set; }

    }
}
