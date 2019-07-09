using Microsoft.EntityFrameworkCore;
using Modelo;
using System;

namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<AtendimentoExame> AtendimentoExames { get; set; }
        public DbSet<AtendimentoMedicamento> AtendimentoMedicamentos { get; set; }
        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<ContaReceber> ContasReceber { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Veterinaria;Trusted_Connection=True;")
                .ConfigureWarnings(warnings =>
                warnings.Default(WarningBehavior.Ignore));


        }
    }
}
