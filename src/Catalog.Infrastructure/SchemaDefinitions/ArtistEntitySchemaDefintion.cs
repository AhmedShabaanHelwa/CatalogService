using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.SchemaDefinitions
{
    public class ArtistEntitySchemaDefintion : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            /* 1 - Define the tabel */
            builder.ToTable("Artists", CatalogContext.DEFAULT_SCHEMA);
            /* 2 - Set the primary key */
            builder.HasKey(k => k.ArtistId);
            /* 3 - Set properties' (columns') constraints */
            builder.Property(p => p.ArtistName)
                .IsRequired();
            /* 4 - Set relationships between tables */
            /* 5 - Customized conversion */
        }
    }
}
