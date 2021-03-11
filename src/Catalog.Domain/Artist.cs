using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain
{
    /// <summary>
    /// Artist type
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// Artist Id
        /// </summary>
        public Guid ArtistId { get; set; }
        /// <summary>
        /// Artist name
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// Reference to a list of albums of this artist
        /// </summary>
        public ICollection<Item> Items { get; set; }
    }
}
