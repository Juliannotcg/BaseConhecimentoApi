using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IOrgaoRepository _orgaoRepository;
        public OrgaoController(IOrgaoRepository orgaoRepository,
            EntityContext context)
        {
            _orgaoRepository = orgaoRepository;
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Orgao>> Get()
        {
            return _context.Orgao.ToList();
        }

    }
}