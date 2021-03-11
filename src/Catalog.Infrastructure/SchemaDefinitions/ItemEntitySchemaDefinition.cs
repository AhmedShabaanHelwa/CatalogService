using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.SchemaDefinitions
{
    public class ItemEntitySchemaDefinition : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            /* 1 - Define the table */
            builder.ToTable<Item>("Items",CatalogContext.DEFAULT_SCHEMA);
            /* 2 - Set the primary key of the table */
            builder.HasKey(k => k.Id);
            /* 3 - Set properties' (columns') constraints */
           
            // Name column
            builder.Property(p => p.Name)
                .IsRequired();
            // Description column
            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(1000);
            
            /* 4 - Set relationships between tables */
            builder
                .HasOne(p => p.Genre)
                .WithMany(c => c.Items)
                .HasForeignKey(k => k.GenreId);
            builder
                .HasOne(p => p.Artist)
                .WithMany(c => c.Items)
                .HasForeignKey(k => k.ArtistId);
            /* 5 - Customized conversions */
            builder.Property(p => p.Price)
                .HasConversion(
                // Read from database as 50.36:EUR
                p => $"{p.Amount}:{p.Currency}",
                // Write in database in original form. int Amount and string currency 
                p => new Price
                {
                    Amount = Convert.ToDecimal(p.Split(':',StringSplitOptions.None)[0]),
                    Currency = p.Split(':',StringSplitOptions.None)[1]
                });
        }
    }
}
