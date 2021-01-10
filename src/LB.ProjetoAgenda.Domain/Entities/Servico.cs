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
    }
}
