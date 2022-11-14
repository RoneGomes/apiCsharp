
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Csharp.Models
{

    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Informe nome do cliente")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe cpf do cliente")]
        [StringLength(50)]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe data de nascimento do cliente")]
        [StringLength(50)]
        public string Data_nascimento { get; set; }

        [Required(ErrorMessage = "Informe senha do  cliente")]
        [StringLength(50)]
        public string Senha { get; set; }

    }
}
