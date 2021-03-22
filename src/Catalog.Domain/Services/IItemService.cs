using Catalog.Domain.Requests.Item;
using Catalog.Domain.Responses.Item;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Domain.Services
{
    /// <summary>
    /// Item service interface
    /// </summary>
    public interface IItemService
    {
        Task<IEnumerable<ItemResponse>> GetItemsAsync();
        Task<ItemResponse> GetItemAsync(GetItemRequest request);
        Task<ItemResponse> AddItemAsync(AddItemRequest request);
        Task<ItemResponse> EditItemAsync(EditItemRequest request);
        // Delete opertion to be implemented as soft delete later
    }
}
