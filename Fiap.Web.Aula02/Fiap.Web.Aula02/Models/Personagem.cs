using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.Aula02.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        [Display(Name ="Nível de Energia")] //Define o label
        public int NivelEnergia { get; set; }
        public bool Capa { get; set; }

        [DataType(DataType.Date), Display(Name = "Data de Criação")] //Ajusta o type do input
        public DateTime DataCriacao { get; set; }

        public Empresa Empresa { get; set; }
    }

    public enum Empresa
    {
        Marvel, DC, Capcom
    }
}
