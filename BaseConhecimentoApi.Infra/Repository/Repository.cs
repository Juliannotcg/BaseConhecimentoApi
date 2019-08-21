using BaseConhecimentoApi.Domain.Interfaces;
using BaseConhecimentoApi.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConhecimentoApi.Infra.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly EntityContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(EntityContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
    }
}
