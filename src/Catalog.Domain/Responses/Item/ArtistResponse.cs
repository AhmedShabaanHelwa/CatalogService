using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Responses.Item
{
    /// <summary>
    /// DTO of Artist response
    /// </summary>
    public class ArtistResponse
    {
        /// <summary>
        /// Artist Id
        /// </summary>
        public Guid ArtistId { get; set; }
        /// <summary>
        /// Artist name
        /// </summary>
        public string ArtistName { get; set; }
    }
}
