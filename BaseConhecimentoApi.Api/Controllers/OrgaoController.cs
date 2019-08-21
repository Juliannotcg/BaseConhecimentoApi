using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using BaseConhecimentoApi.Api.ViewModels.Orgaos;
using BaseConhecimentoApi.Domain.Interfaces;
using BaseConhecimentoApi.Domain.Models;
using BaseConhecimentoApi.Infra.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaseConhecimentoApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrgaoController : ControllerBase
    {
        private readonly EntityContext _context;
        private readonly IMapper _mapper;
        private readonly IOrgaoRepository _orgaoRepository;
        public OrgaoController(IOrgaoRepository orgaoRepository,
            EntityContext context,
            IMapper mapper)
        {
            _mapper = mapper;
            _orgaoRepository = orgaoRepository;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<OrgaoViewModel> GetAll()
        {
            return _orgaoRepository.GetAll().ProjectTo<OrgaoViewModel>(_mapper.ConfigurationProvider);
        }

        [HttpPost]
        public void Post([FromBody] OrgaoViewModel orgaoViewModel)
        {
            var orgao = _mapper.Map<Orgao>(orgaoViewModel);
            _orgaoRepository.Add(orgao);

            if (_orgaoRepository.SaveChanges() > 0)
            {

            }
        }

        [HttpDelete]
        public void Remove(int id)
        {
           
            _orgaoRepository.Remove(id);

            if (_orgaoRepository.SaveChanges() > 0)
            {

            }
        }

    }
}