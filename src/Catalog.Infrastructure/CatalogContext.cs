using Catalog.Domain;
using Catalog.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Infrastructure
{
    public class CatalogContext : DbContext, IUnitOfWork
    {
        // Constants
        public const string DEFAULT_SCHEMA = "catalog";
        
        // Properties
        /// <summary>
        /// Items table in database
        /// </summary>
        public DbSet<Item> Items { set; get; }
        /// <summary>
        /// Constructor of contect class to pass options to the DbContext base class
        /// </summary>
        /// <param name="options">Options of database to be passed to the ORM</param>
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        }
        /// <summary>
        /// Effective save of changes in database
        /// </summary>
        /// <param name="cancellationToken">Allows to stop pending async operations</param>
        /// <returns>true or false</returns>
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken)
        {
            // Calls SaveChangesAsync derived by DbContext class and declared by IUnitOfWork interface.
            await SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
