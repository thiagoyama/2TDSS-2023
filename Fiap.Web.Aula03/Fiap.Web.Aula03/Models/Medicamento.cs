using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("Tbl_Medicamento")]
    public class Medicamento
    {
        public int MedicamentoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [DataType(DataType.Date)]
        public DateTime Validade { get; set; }
        public string Laboratorio { get; set; }
        public IList<PacienteMedicamento> PacientesMedicamentos { get; set; }
    }
}
