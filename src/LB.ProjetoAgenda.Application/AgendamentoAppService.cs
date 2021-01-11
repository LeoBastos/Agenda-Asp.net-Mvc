using AutoMapper;
using LB.ProjetoAgenda.Application.Interfaces;
using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.Domain.Entities;
using LB.ProjetoAgenda.Infra.Data.Repositories;
using System;
using System.Collections.Generic;

namespace LB.ProjetoAgenda.Application
{
    public class AgendamentoAppService : IAgendamentoAppService
    {
        private readonly AgendamentoRepository _agendamentoRepository;

        public AgendaViewModel Adicionar(AgendaViewModel agendamentoAgendaViewModel)
        {
            var agendamento = Mapper.Map<AgendaViewModel, Agendamento>(agendamentoAgendaViewModel);
            var cliente = Mapper.Map<AgendaViewModel, Cliente>(agendamentoAgendaViewModel);
            var servico = Mapper.Map<AgendaViewModel, Servico>(agendamentoAgendaViewModel);

            agendamento.Clientes.Add(cliente);
            agendamento.Servicos.Add(servico);

            _agendamentoRepository.Adicionar(agendamento);

            return agendamentoAgendaViewModel;
        }

        public AgendamentoViewModel Atualizar(AgendamentoViewModel agendamentoViewModel)
        {
            _agendamentoRepository.Atualizar(Mapper.Map<AgendamentoViewModel, Agendamento>(agendamentoViewModel));
            
            return agendamentoViewModel;
        }

        public void Dispose()
        {
            _agendamentoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public AgendamentoViewModel ObterPorFormaPagamento(string forma)
        {
            return Mapper.Map<Agendamento, AgendamentoViewModel>(_agendamentoRepository.ObterPorFormaPagamento(forma));
        }

        public AgendamentoViewModel ObterPorTipo(string tipo)
        {
            return Mapper.Map<Agendamento, AgendamentoViewModel>(_agendamentoRepository.ObterPorTipo(tipo));
        }

        public IEnumerable<AgendamentoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Agendamento>, IEnumerable<AgendamentoViewModel>>(_agendamentoRepository.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _agendamentoRepository.Remover(id);
        }
    }
}
