using LB.ProjetoAgenda.Domain.Entities;
using LB.ProjetoAgenda.Domain.Interfaces.Repository;
using System;
using System.Linq;


namespace LB.ProjetoAgenda.Infra.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public Cliente ObterPorCelular(string celular)
        {
            return Buscar(c => c.Celular == celular).FirstOrDefault();
        }

        public Cliente ObterPorCpf(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        public override void Remover(Guid id)
        {
            var cliente = ObterPorId(id);
            cliente.Ativo = false;
            Atualizar(cliente);
        }
    }
}
