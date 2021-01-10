using LB.ProjetoAgenda.Domain.Entities;
using LB.ProjetoAgenda.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB.ProjetoAgenda.Infra.Data.Context
{
    class ProjetoAgendaContext : DbContext
    {
        public ProjetoAgendaContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Servico> Servico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new AgendamentoConfig());
            modelBuilder.Configurations.Add(new ServicoConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
