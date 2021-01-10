using System;
using System.Collections.Generic;

namespace LB.ProjetoAgenda.Domain.Entities
{
    public class Agendamento
    {
        public Agendamento()
        {
            AgendamentoId = Guid.NewGuid();
        }

        public Guid AgendamentoId { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Servico> Servicos { get; set; }
        public DateTime DataAgendamento { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public string Tipo { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime DataCadastroAgendamento { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Guid ServicoId { get; set; }
        public Servico Servico { get; set; }
    }
}
