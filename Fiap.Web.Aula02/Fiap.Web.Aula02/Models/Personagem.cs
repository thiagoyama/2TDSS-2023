namespace Fiap.Web.Aula02.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string? Nome { get; set; }        
        public int NivelEnergia { get; set; }
        public bool Capa { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
