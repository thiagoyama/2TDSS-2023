using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("Tbl_Exame")]
    public class Exame
    {
        public int ExameId { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preparo { get; set; }
        [Required]
        public DateTime Data { get; set; }

        //N:1
        public Paciente Paciente { get; set; }
        public int PacienteId { get; set; }

    }
}
