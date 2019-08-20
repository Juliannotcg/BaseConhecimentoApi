using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseConhecimentoApi.Api.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg => { cfg.AddProfiles(typeof(Guard.StaticGuard).Assembly); });
        }
    }
}
