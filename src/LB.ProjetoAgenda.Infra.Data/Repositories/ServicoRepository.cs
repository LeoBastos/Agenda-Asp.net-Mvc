using LB.ProjetoAgenda.Domain.Entities;
using LB.ProjetoAgenda.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB.ProjetoAgenda.Infra.Data.Repositories
{
    public class ServicoRepository : Repository<Servico>, IServicoRepository
    {
        public Servico ObetrPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Servico ObterPorNomeServico(string nomeServico)
        {
            return Buscar(s => s.NomeServico == nomeServico).FirstOrDefault();
        }

       
    }
}
