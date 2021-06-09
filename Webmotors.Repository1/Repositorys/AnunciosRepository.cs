using System.Linq;
using Webmotors.Model;
using Webmotors.Repository.Repositorys;

namespace Webmotors.Repository.Repositorys
{
   public class AnunciosRepository : BaseRepository<webMotorsDbContext, Anuncios>, IAnunciosRepository
    {
        public AnunciosRepository(webMotorsDbContext contexto)
        {
            DataContext = contexto;
            DbSet = DataContext.Set<Anuncios>();
        }

        public Anuncios anuncios()
        {

        }
    }

    public interface IAnunciosRepository
    { 
    
    }
}
