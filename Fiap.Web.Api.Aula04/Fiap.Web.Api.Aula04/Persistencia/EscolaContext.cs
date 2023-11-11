using Fiap.Web.Api.Aula04.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.Api.Aula04.Persistencia
{
    public class EscolaContext : DbContext
    {
        public DbSet<Escola> Escolas { get; set; }

        public EscolaContext(DbContextOptions op) : base(op)
        {
            
        }

    }
}
