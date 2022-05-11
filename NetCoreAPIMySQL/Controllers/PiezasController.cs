using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPIMySQL.Data.Repositories;
using NetCoreAPIMySQL.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiezasController : ControllerBase
    {
        private readonly IPiezaRepository _piezaRepository;
        public PiezasController(IPiezaRepository piezaRepository)
        {
            _piezaRepository = piezaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMarcos()
        {
            return Ok(await _piezaRepository.GetAllPiezas());
        }
        [HttpGet("{id}")]
        /*public async Task<IActionResult> GetMarcoDetails(int id)
        {
            return Ok(await _piezaRepository.GetPiezaDetails(id));
        }

        [HttpGet]
        [Route("api/PiezasOfMarco/{id}")]*/
        public async Task<IActionResult> GetAllPiezasOfMarco(int id)
        {
            return Ok(await _piezaRepository.GetAllPiezasOfMarco(id));
        }

        [HttpPost]
        //public IActionResult Prueba(IEnumerable<string> values)
        public IActionResult Prueba(DatosViewModel datosIdsViewModel)
        {
            Datos datos = datosIdsViewModel.datosIniciales;
            datos.Perfiles = datosIdsViewModel.perfiles;

            return Ok(CalculosTornilleria.CalculosTornillos(datos));
        }


    }
}
