using System.Collections.Generic;
using System.Linq;
using Webmotors.Model;

namespace Webmotors.Repository.Repositorys
{
   public class AnunciosRepository : BaseRepository<webMotorsDbContext, Anuncios>, IAnunciosRepository
    {
        public AnunciosRepository(webMotorsDbContext contexto)
        {
            DataContext = contexto;
            DbSet = DataContext.Set<Anuncios>();
        }

        public List<Anuncios> ListaAnuncios() => DataContext.Anuncios.ToList();
        public Anuncios anunciosPorId(int id) => DataContext.Anuncios.Where(d => d.ID.Equals(id)).FirstOrDefault();
        public void AtualizarAnuncio(Anuncios anuncios)
        {
            var dbAnuncio = DataContext.Anuncios.Where(d => d.ID.Equals(anuncios.ID)).FirstOrDefault();
            if (dbAnuncio != null)
            {
                dbAnuncio.marca = anuncios.marca;
                dbAnuncio.ano = anuncios.ano;
                dbAnuncio.modelo = anuncios.modelo;
                dbAnuncio.observacao = anuncios.observacao;
                dbAnuncio.versao = anuncios.versao;
                dbAnuncio.quilometragem = anuncios.quilometragem;
                DataContext.Update(dbAnuncio);
                DataContext.SaveChanges();
            }

           
        }
        public void CriarAnuncios (Anuncios anuncios)
        {
            DataContext.Add(anuncios);
            DataContext.SaveChanges();
        }
        public void DeletarAnuncio(int id)
        {
            var anuncioDb = DataContext.Anuncios.Where(d => d.ID.Equals(id)).FirstOrDefault();
            DataContext.Remove(anuncioDb);
        }

    }

    public interface IAnunciosRepository : IBaseRepository<Anuncios>
    {
        public List<Anuncios> ListaAnuncios();
        public void CriarAnuncios(Anuncios anuncios);
        public Anuncios anunciosPorId(int id);
        public void DeletarAnuncio(int id);
        public void AtualizarAnuncio(Anuncios anuncios);


    }
}
