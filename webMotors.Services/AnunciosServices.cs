using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Webmotors.Model;
using Webmotors.Repository.Repositorys;

namespace webMotors.Services
{
    public class AnunciosServices : IAnunciosServices
    {
        private readonly ILogger<IAnunciosServices> _logger;
        private readonly IAnunciosRepository _anuncioRepository;
        public AnunciosServices(ILogger<IAnunciosServices> logger,
                         IAnunciosRepository anuncioRepository)
        {
            _logger = logger;
            _anuncioRepository = anuncioRepository ;
        }

        public void Add(Anuncios anuncios)
        {
     
            try
            {
                _anuncioRepository.CriarAnuncios(anuncios);
               var ret = "Anuncio inserido com sucesso";
                _logger.LogInformation(ret);
            }
            catch (Exception ex)
            {

               _logger.LogError(ex.Message);

            }
           }
        public void delete(int id)
        {
            var ret = "";
            try
            {
                _anuncioRepository.DeletarAnuncio(id);
                ret = "Anuncio excluido com sucesso";
                _logger.LogInformation(ret);
            }
            catch (Exception ex)
            {

                ret = "Erro Ao excluir Anuncio " + ex.Message;
                _logger.LogError(ex.Message); 
            }

      }
        public List<Anuncios> ListarTodosAnuncios() => _anuncioRepository.ListaAnuncios();
        public void Atualiza(Anuncios anuncios)
        {
            var ret = "";
            try
            {
                _anuncioRepository.AtualizarAnuncio(anuncios);
                ret = "Anuncio atualuzado com sucesso";
                _logger.LogInformation(ret);
            }
            catch (Exception ex)
            {

                ret = "Erro Ao atualizar Anuncio " + ex.Message;
                _logger.LogError(ex.Message);

            }
   
        }
        public Anuncios AnuncioPorId(int id) => _anuncioRepository.anunciosPorId(id);

    }

    public interface IAnunciosServices
    {
        public void Add(Anuncios anuncios);
        public List<Anuncios> ListarTodosAnuncios();
        public void delete(int id);
        public void Atualiza(Anuncios anuncios);
        public Anuncios AnuncioPorId(int id);

    }
}
