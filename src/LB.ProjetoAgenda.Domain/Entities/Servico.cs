using System;


namespace LB.ProjetoAgenda.Domain.Entities
{
    public class Servico
    {
        public Servico()
        {
            ServicoId = Guid.NewGuid();
        }

        public Guid ServicoId { get; set; }
        public string NomeServico { get; set; }
        public Guid AgendamentoId { get; set; }
        public Agendamento Agendamento { get; set; }
    }
}
