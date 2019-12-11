using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos;
using AutoMapper;
using Dominio.entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.contracts;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerrosController : ControllerBase
    {


        public readonly IPerrosService perroService;
        private readonly IMapper _mapper;
        public PerrosController(IPerrosService perros, IMapper mapper)
        {
            this.perroService = perros;
            _mapper = mapper;
        }
      
        // POST: api/Perros/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] PerroDto perroDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
           
            var perroMappeado = this._mapper.Map<Perros>(perroDto);

            this.perroService.Create(perroMappeado);
            return Ok();
        }

        // GET: api/Perros/TraerTodo
        [HttpGet("TraerTodo")]
        public async Task<IActionResult> TraerTodo()
        {
            var listado= await this.perroService.listado();
            var listadoMapeado = this._mapper.Map<List<PerroDto>>(listado);
            return Ok(listadoMapeado);
        }
    }
}
