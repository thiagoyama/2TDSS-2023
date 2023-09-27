namespace Fiap.Web.Aula02.Models
{
    public class Equipamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public Raridade Raridade { get; set; }
        public string? Descricao { get; set; }
    }

    public enum Raridade
    {
        Comum, Incomum, Raro, Mitico, Lendario
    }
}
