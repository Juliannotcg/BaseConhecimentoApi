using System;
using System.Linq;

namespace BaseConhecimentoApi.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(int id);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        int SaveChanges();
    }
}
