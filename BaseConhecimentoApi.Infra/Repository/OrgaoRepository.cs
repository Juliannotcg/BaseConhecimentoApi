using BaseConhecimentoApi.Domain.Interfaces;
using BaseConhecimentoApi.Domain.Models;
using BaseConhecimentoApi.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseConhecimentoApi.Infra.Repository
{
    public class OrgaoRepository : Repository<Orgao>, IOrgaoRepository
    {
        public OrgaoRepository(EntityContext context) : base(context)
        {
        }
    }
}
