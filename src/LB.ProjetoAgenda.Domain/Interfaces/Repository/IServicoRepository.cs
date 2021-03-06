﻿using LB.ProjetoAgenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB.ProjetoAgenda.Domain.Interfaces.Repository
{
    public interface IServicoRepository : IRepository<Servico>
    {
        Servico ObterPorNomeServico(string nomeServico);
        Servico ObetrPorId(Guid id);        
    }
}
