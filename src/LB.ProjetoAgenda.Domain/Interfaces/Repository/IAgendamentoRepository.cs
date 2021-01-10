using LB.ProjetoAgenda.Domain.Entities;
using System;


namespace LB.ProjetoAgenda.Domain.Interfaces.Repository
{
    public interface IAgendamentoRepository : IRepository<Agendamento>
    {
        Agendamento ObterPorTipo(string tipo);
        Agendamento ObterPorFormaPagamento(string forma);        
    }
}
