using Fiap.Web.Aula03.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.Aula03.Persistencia
{
    //Classe que gerencia as entidades
    public class HospitalContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<PacienteMedicamento> PacientesMedicamentos { get; set; }

        public HospitalContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a PK da tabela associativa
            modelBuilder.Entity<PacienteMedicamento>()
                .HasKey(p => new { p.PacienteId, p.MedicamentoId });

            //Configurar a relação da tabela associativa com o Paciente
            modelBuilder.Entity<PacienteMedicamento>()
                .HasOne(p => p.Paciente)
                .WithMany(p => p.PacientesMedicamentos)
                .HasForeignKey(p => p.PacienteId);

            //Configurar a relação da tabela associativa com o Medicamento
            modelBuilder.Entity<PacienteMedicamento>()
                .HasOne(p => p.Medicamento)
                .WithMany(p => p.PacientesMedicamentos)
                .HasForeignKey(p => p.MedicamentoId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
