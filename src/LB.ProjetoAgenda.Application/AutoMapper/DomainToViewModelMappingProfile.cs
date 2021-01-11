using System;
using AutoMapper;
using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.Domain.Entities;

namespace LB.ProjetoAgenda.Application.AutoMapper
{
    class DomainToViewModelMappingProfile : Profile
    {
       protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Cliente, AgendaViewModel>();
            Mapper.CreateMap<Agendamento, AgendamentoViewModel>();
            Mapper.CreateMap<Agendamento, AgendaViewModel>();
            Mapper.CreateMap<Servico, ServicoViewModel>();
            Mapper.CreateMap<Servico, AgendaViewModel>();
        }
    }
}
