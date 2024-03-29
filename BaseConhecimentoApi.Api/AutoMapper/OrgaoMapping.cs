﻿using AutoMapper;
using BaseConhecimentoApi.Api.ViewModels.Orgaos;
using BaseConhecimentoApi.Domain.Models;


namespace BaseConhecimentoApi.Api.AutoMapper
{
    public class OrgaoMapping : Profile
    {
        public OrgaoMapping()
        {
            CreateMap<OrgaoViewModel, Orgao>();
        }
    }
}
