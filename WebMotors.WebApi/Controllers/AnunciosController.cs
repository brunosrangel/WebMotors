using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webMotors.Services;
using Webmotors.Model;

namespace WebMotors.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Consumes("application/json")]
    public class AnunciosController : Controller, IAnunciosController
    {
        private readonly IAnunciosServices _anunciosServices;
        public AnunciosController(IAnunciosServices anunciosServices)
        {
            _anunciosServices = anunciosServices;
        }
        [Route("IncluirAnuncios")]
        [HttpPost()]
        public IActionResult IncluirAnuncios([FromBody] Anuncios anuncios)
        {
            try
            {
                _anunciosServices.Add(anuncios);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
            
        }

        [Route("DeletarAnuncios/:id")]
        [HttpPost("DeletarAnuncios/{id}")]
        public IActionResult DeletarAnuncios(int id)
        {
            try
            {
                _anunciosServices.delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [Route("AtualizarAnuncios")]
        [HttpPost()]
        public IActionResult AtualizarAnuncios([FromBody] Anuncios anuncios)
        {
            try
            {
                _anunciosServices.Atualiza(anuncios);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [Route("ListaAnucioPorId/:id")]
        [HttpGet("ListaAnucioPorId/{id}")]
        public IActionResult ListaAnucioPorId(int id)
        {
            try
            {
                var ret = _anunciosServices.AnuncioPorId(id);
                return Ok(ret);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [Route("ListaTodosAnuncios")]
        [HttpGet()]
        public IActionResult ListaTodosAnuncios()
        {
            try
            {
                var ret = _anunciosServices.ListarTodosAnuncios();
                return Ok(ret);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }


    }

    internal interface IAnunciosController
    {
        public IActionResult IncluirAnuncios([FromBody] Anuncios anuncios);
        public IActionResult DeletarAnuncios(int id);
        public IActionResult AtualizarAnuncios([FromBody] Anuncios anuncios);
        public IActionResult ListaAnucioPorId(int id);
        public IActionResult ListaTodosAnuncios();
    }
}
