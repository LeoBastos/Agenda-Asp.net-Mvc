using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace LB.ProjetoAgenda.Infra.Data.EntityConfig
{
    public class ServicoConfig : EntityTypeConfiguration<Servico>
    {
        public ServicoConfig()
        {
            HasKey(s => s.ServicoId);

            Property(s => s.NomeServico)
                .IsRequired();

            ToTable("Serviços");
        }
    }
}
