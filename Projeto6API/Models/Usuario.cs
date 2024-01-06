using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto6API.Models
{
    [Table("Usuario")]
    public class Usuario
    {

        [Key]
        public int Id { get; set; }

        [Required] public string Name { get; set; }
        [Required] public string Email { get; set; }
        [Required] public DateTime dataCadastro { get; set; }
        [Required] public string Senha { get; set; }
    }
}
