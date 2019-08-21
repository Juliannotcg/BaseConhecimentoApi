using AutoMapper;
using BaseConhecimentoApi.Api.ViewModels.Orgaos;
using BaseConhecimentoApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseConhecimentoApi.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Orgao, OrgaoViewModel>();
        }
    }
}
