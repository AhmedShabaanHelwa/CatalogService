using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Repositories
{
    /// <summary>
    /// Interface of Item repository to Get,Write and Update items in database
    /// </summary>
    public interface IItemRepository : IRepository
    {
        /// <summary>
        /// Get all items aynchronously
        /// </summary>
        /// <returns>List of available items in database</returns>
        Task<IEnumerable<Item>> GetAsync();
        /// <summary>
        /// Get an item by id
        /// </summary>
        /// <param name="id">id of item needed</param>
        /// <returns></returns>
        Task<Item> GetAsync(Guid id);
        /// <summary>
        /// Adds an item to the items table in database
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Item Add(Item item);
        /// <summary>
        /// Updates an existing item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Item Update(Item item);

    }
}
