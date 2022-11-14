using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace ApiAgencia_Csharp.Models
{
    namespace API_Csharp.Models
    {

        [Table("Passagem")]
        public class Passagem
        {
            [Key]
            public int PassagemId { get; set; }

            [Required(ErrorMessage = "Informe data da passagem")]
            [StringLength(50)]
            public string Data_passagem { get; set; }

            [Required(ErrorMessage = "Informe hora de partida")]
            [StringLength(50)]
            public string Hora_partida { get; set; }

            [Required(ErrorMessage = "Informe hora de chegada")]
            [StringLength(50)]
            public string Hora_chegada { get; set; }

            [Required(ErrorMessage = "Informe a origem")]
            [StringLength(50)]
            public string origem{ get; set; }

            [Required(ErrorMessage = "Informe a destino")]
            [StringLength(50)]
            public string destino { get; set; }

            [Required(ErrorMessage = "Informe o valor")]
            [StringLength(50)]
            public string valor { get; set; }

            [Required(ErrorMessage = "Informe tipo de voo")]
            [StringLength(50)]
            public string tipo_voo{ get; set; }

            [Required(ErrorMessage = "Informe o nome do cliente")]
            [StringLength(50)]
            public string nome_cliente { get; set; }

            [Required(ErrorMessage = "Informe o cpf")]
            [StringLength(50)]
            public string cpf { get; set; }

        }
    }


