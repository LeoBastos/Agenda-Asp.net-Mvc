using LB.ProjetoAgenda.Domain.Entities;
using LB.ProjetoAgenda.Domain.Interfaces.Repository;
using System.Linq;


namespace LB.ProjetoAgenda.Infra.Data.Repositories
{
    public class AgendamentoRepository : Repository<Agendamento>, IAgendamentoRepository
    {
        public Agendamento ObterPorFormaPagamento(string forma)
        {
            return Buscar(a => a.FormaPagamento == forma).FirstOrDefault();
        }

        public Agendamento ObterPorTipo(string tipo)
        {
            return Buscar(a => a.Tipo == tipo).FirstOrDefault(); 
        }
    }
}

