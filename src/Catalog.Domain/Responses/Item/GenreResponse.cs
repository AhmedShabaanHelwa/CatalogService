using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Responses.Item
{
    public class GenreResponse
    {
        /// <summary>
        /// Genre Id
        /// </summary>
        public Guid GenreId { get; set; }
        /// <summary>
        /// Genre Description
        /// </summary>
        public string GenreDescription { get; set; }
    }
}
