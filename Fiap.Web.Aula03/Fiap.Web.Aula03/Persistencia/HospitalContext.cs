using Fiap.Web.Aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.Aula03.Persistencia
{
    //Classe que gerencia as entidades
    public class HospitalContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }

        public HospitalContext(DbContextOptions op) : base(op) { }
    }
}
