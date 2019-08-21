using AutoMapper;
using BaseConhecimentoApi.Api.ViewModels.Orgaos;
using BaseConhecimentoApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseConhecimentoApi.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<OrgaoViewModel, Orgao>();
     
        }
    }
}
