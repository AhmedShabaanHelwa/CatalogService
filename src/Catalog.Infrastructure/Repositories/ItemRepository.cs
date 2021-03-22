using Catalog.Domain.Entities;
using Catalog.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        // Private fields
        private readonly CatalogContext _context;
        // Public properties
        public IUnitOfWork UnitOfWork => _context;
        public ItemRepository(CatalogContext context)
        {
            _context = context ?? throw new 
                ArgumentNullException(nameof(_context));
        }

        // Public methods
        /// <summary>
        /// Gets a list of items from items table in database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Item>> GetAsync()
        {
            return await _context.Items
                .AsNoTracking()
                .ToListAsync();
        }
        /// <summary>
        /// Gets an item by id
        /// </summary>
        /// <param name="id">Id of certain item to be getten</param>
        /// <returns></returns>
        public async Task<Item> GetAsync(Guid id)
        {
            var item = await _context.Items
                .AsNoTracking()
                .Where(x => x.Id == id)
                .Include(x => x.Genre)
                .Include(x => x.Artist)
                .FirstOrDefaultAsync();
            return item;
        }
        /// <summary>
        /// Adds an item to items table in database
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Item Add(Item item)
        {
            return _context.Items.Add(item).Entity;
        }
        /// <summary>
        /// Updates an existing item in items table in database
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Item Update(Item item)
        {
            /* returns the entry of the passed item entity 
             * and change the state to modified sothat being effectively
             * saved by UnitOfWork
             */
            _context.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
