using LB.ProjetoAgenda.Domain.Interfaces.Repository;
using LB.ProjetoAgenda.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace LB.ProjetoAgenda.Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private ProjetoAgendaContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new ProjetoAgendaContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            var result = DbSet.Add(obj);
            SaveChanges();
            return result;
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entrada = Db.Entry(obj);
            DbSet.Attach(obj);
            entrada.State = EntityState.Modified;
            SaveChanges();
            
            return obj;
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos() //(int t, int s)
        {
            //return DbSet.Take(t).Skip(s).ToList();
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }

    
}
