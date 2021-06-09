using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Webmotors.Model;

namespace Webmotors.Repository.Configuration
{
    class AnunciosConfiguration : IEntityTypeConfiguration<Anuncios>
    {
        public void Configure(EntityTypeBuilder<Anuncios> builder) 
        {
           // builder.ToTable("tb_AnuncioWebmotors");
            builder.HasKey(c => c.ID);
            builder.HasKey(c => c.marca);
            builder.HasKey(c => c.modelo);
            builder.HasKey(c => c.observacao);
            builder.HasKey(c => c.quilometragem);
            builder.HasKey(c => c.versao);
            builder.HasKey(c => c.ano);

        }
    }
}
