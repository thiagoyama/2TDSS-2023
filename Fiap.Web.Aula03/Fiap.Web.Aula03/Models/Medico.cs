namespace Fiap.Web.Aula03.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public int Crm { get; set; }
        public string? Nome { get; set; }
        public decimal Salario { get; set; }
        public Especialidade Especialidade { get; set; }
    }

    public enum Especialidade
    {
        Neurologista, Pediatra, Cardiologista, Endocrinologista
    }
}
