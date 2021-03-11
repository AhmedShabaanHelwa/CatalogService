using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.SchemaDefinitions
{
    public class GenreEntitySchemaDefinition : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            /* 1 - Define the tabel */
            builder.ToTable("Genres",CatalogContext.DEFAULT_SCHEMA);
            /* 2 - Set the primary key */
            builder.HasKey(k => k.GenreId);
            /* 3 - Set properties' (columns') constraints */
            builder.Property(p => p.GenreDescription)
                .HasMaxLength(1000);
            /* 4 - Set relationships between tables */
            /* 5 - Customized conversion */
        }
    }
}
