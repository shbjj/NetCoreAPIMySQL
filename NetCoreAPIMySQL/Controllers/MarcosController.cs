using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPIMySQL.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcosController : ControllerBase
    {
        private readonly IMarcoRepository _marcoRepository;
        public MarcosController(IMarcoRepository marcoRepository)
        {
            _marcoRepository = marcoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMarcos()
        {
            return Ok(await _marcoRepository.GetAllMarcos());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMarcoDetails(int id)
        {
            return Ok(await _marcoRepository.GetMarcoDetails(id));
        }

    }
}
