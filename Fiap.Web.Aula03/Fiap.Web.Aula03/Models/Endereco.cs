using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.Aula03.Models
{
    [Table("Tbl_Endereco")]
    public class Endereco
    {
        public int EnderecoId { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public string Cep { get; set; }
    }
}
