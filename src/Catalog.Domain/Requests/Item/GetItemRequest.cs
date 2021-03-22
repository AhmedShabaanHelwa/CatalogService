using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Requests.Item
{
    /// <summary>
    /// DTO of Get Item request
    /// </summary>
    public class GetItemRequest
    {
        public Guid Id { get; set; }
    }
}
