using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("Tbl_Paciente")]
    public class Paciente
    {
        [Column("Id")]
        public int PacienteId { get; set; }

        [Required, MaxLength(80)]
        public string? Nome { get; set; }

        [Required, MaxLength(11)]
        public string? Cpf { get; set; }
        
        [Column("Dt_Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("Ds_Modalidade"), Required]
        public ModalidadeAtendimento ModalidadeAtendimento { get; set; }
    }

    public enum ModalidadeAtendimento
    {
        PlanoSaude, Sus, Particular
    }

}
