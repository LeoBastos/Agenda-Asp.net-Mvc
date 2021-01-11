using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB.ProjetoAgenda.Application.Interfaces
{
    interface IAgendamentoAppService : IDisposable
    {
        AgendaViewModel Adicionar(AgendaViewModel agendamentoAgendaViewModel);
        AgendamentoViewModel ObterPorTipo(string tipo);
        AgendamentoViewModel ObterPorFormaPagamento(string forma);      
        IEnumerable<AgendamentoViewModel> ObterTodos();
        AgendamentoViewModel Atualizar(AgendamentoViewModel agendamentoViewModel);
        void Remover(Guid id);
    }
}
