using BaseConhecimentoApi.Domain.Interfaces;
using BaseConhecimentoApi.Domain.Models;
using BaseConhecimentoApi.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseConhecimentoApi.Infra.Repository
{
    public class OrgaoRepository : IOrgaoRepository
    {
        protected readonly EntityContext _context;

        public OrgaoRepository(EntityContext context)
        {
            _context = context;
        }

        public void Add(Orgao obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Orgao obj)
        {
            throw new NotImplementedException();
        }
    }
}
