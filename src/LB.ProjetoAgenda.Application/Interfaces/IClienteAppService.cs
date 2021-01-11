using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.Collections.Generic;


namespace LB.ProjetoAgenda.Application.Interfaces
{
    interface IClienteAppService : IDisposable
    {
        AgendaViewModel Adicionar(AgendaViewModel clienteAgendaViewModel);
        ClienteViewModel ObterPorId(Guid id);
        ClienteViewModel ObterPorCpf(string cpf);
        ClienteViewModel ObterPorEmail(string email);
        IEnumerable<ClienteViewModel> ObterTodos();
        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);

    }
}
