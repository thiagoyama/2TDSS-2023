namespace Fiap.Web.Aula03.Models
{
    public class PacienteMedicamento
    {
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }
    }
}
