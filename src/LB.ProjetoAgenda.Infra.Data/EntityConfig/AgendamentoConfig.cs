using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.Data.Entity.ModelConfiguration;

namespace LB.ProjetoAgenda.Infra.Data.EntityConfig
{
    public class AgendamentoConfig : EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoConfig()
        {
            HasKey(a => a.AgendamentoId);
            
            Property(a => a.DataAgendamento)
                .IsRequired();

            Property(a => a.HoraInicial)
                .IsRequired();

            Property(a => a.HoraFinal)
                .IsRequired();                

            Property(a => a.Tipo)
                .IsRequired();

            Property(a => a.FormaPagamento)
                .IsRequired();

            ToTable("Agendamentos");


        }
    }
}
