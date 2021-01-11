using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB.ProjetoAgenda.Application.Interfaces
{
    interface IServicoAppService : IDisposable
    {
        AgendaViewModel Adicionar(AgendaViewModel servicoAgendaViewModel);
        ServicoViewModel ObterPorNomeServico(string nomeServico);        
        IEnumerable<ServicoViewModel> ObterTodos();
        ServicoViewModel Atualizar(ServicoViewModel servicoViewModel);
        void Remover(Guid id);
    }
}
