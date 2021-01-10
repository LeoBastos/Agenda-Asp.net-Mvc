using LB.ProjetoAgenda.Domain.Entities;
using System;


namespace LB.ProjetoAgenda.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        Cliente ObterPorCelular(string celular);
    }
}
