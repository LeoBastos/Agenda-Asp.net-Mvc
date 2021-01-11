using AutoMapper;
using LB.ProjetoAgenda.Application.Interfaces;
using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.Domain.Entities;
using LB.ProjetoAgenda.Infra.Data.Repositories;
using System;
using System.Collections.Generic;


namespace LB.ProjetoAgenda.Application
{
    public class ServicoAppService : IServicoAppService
    {
        private readonly ServicoRepository _servicoRepository;

        public AgendaViewModel Adicionar(AgendaViewModel servicoAgendaViewModel)
        {
            var servico = Mapper.Map<AgendaViewModel, Servico>(servicoAgendaViewModel);
            
           _servicoRepository.Adicionar(servico);

            return servicoAgendaViewModel;
        }

        public ServicoViewModel Atualizar(ServicoViewModel servicoViewModel)
        {
            _servicoRepository.Atualizar(Mapper.Map<ServicoViewModel, Servico>(servicoViewModel));

            return servicoViewModel;
        }

        public void Dispose()
        {
            _servicoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public ServicoViewModel ObterPorNomeServico(string nomeServico)
        {
            return Mapper.Map<Servico, ServicoViewModel>(_servicoRepository.ObterPorNomeServico(nomeServico));
        }

        public ServicoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Servico, ServicoViewModel>(_servicoRepository.ObterPorId(id));
        }

        

        public IEnumerable<ServicoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Servico>, IEnumerable<ServicoViewModel>>(_servicoRepository.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _servicoRepository.Remover(id);
        }
    }
}
