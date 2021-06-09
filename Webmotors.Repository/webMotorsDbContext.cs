using Microsoft.EntityFrameworkCore;
using System;
using Webmotors.Model;
using Webmotors.Repository.Configuration;

namespace Webmotors.Repository
{
    public class webMotorsDbContext : DbContext
    {
        public DbSet<Anuncios> Anuncios {get; set;}
        public webMotorsDbContext(DbContextOptions<webMotorsDbContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnunciosConfiguration());

        }
    }
}
