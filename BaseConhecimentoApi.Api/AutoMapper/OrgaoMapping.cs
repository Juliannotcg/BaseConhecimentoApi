using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseConhecimentoApi.Api.AutoMapper
{
    public class OrgaoMapping : Profile
    {
        public OrgaoMapping()
        {
            //CreateMap<OrgaoViewModel, Orgao>()
            //   .ForMember(dest => dest.DataHoraAlteracao, opt => opt.Ignore())
            //   .ForMember(dest => dest.DataHoraExclusao, opt => opt.Ignore())
            //   .ForMember(dest => dest.DataHoraInclusao, opt => opt.Ignore())
            //   .ForMember(dest => dest.InfraestruturaInstalacao, opt => opt.Ignore());
        }
    }
}
