using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webMotors.Services;
using Webmotors.Model;

namespace WebMotors.WebApi
{
    [Route("api/[controller]")]
    public class AnunciosController : Controller, IAnunciosController
    {
        private readonly IAnunciosServices _anunciosService;
        public AnunciosController(IAnunciosServices anunciosServices)
        {
            _anunciosService = anunciosServices; 
        }
        [HttpPost()]
        public IActionResult IncluiAnuncio([FromBody] Anuncios anuncios)
        {
            _anunciosService.Add(anuncios);

            var ret = new ModelDto.ModelDto();
            return Ok();
        }
    }

    internal interface IAnunciosController
    {
    }
}
