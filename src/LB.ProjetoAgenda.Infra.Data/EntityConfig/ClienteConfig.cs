using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;


namespace LB.ProjetoAgenda.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            HasKey(c => c.ClienteId);
            //Chave Composta (id ou Cpf)
            //HasKey(c => new { c.ClienteId, c.CPF });
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("Nome");

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

            Property(c => c.Celular)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();                

            Property(c => c.DataNascimento)
                .IsRequired();

            Property(c => c.Ativo)
                .IsRequired();

            ToTable("Clientes");


        }
    }
}
