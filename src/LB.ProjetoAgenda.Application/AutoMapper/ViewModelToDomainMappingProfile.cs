using AutoMapper;
using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB.ProjetoAgenda.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<AgendaViewModel, Cliente>();
            Mapper.CreateMap<AgendamentoViewModel, Agendamento>();
            Mapper.CreateMap<AgendaViewModel, Agendamento>();
            Mapper.CreateMap<ServicoViewModel, Servico>();
            Mapper.CreateMap<AgendaViewModel, Servico>();
        }
        
    }
}
