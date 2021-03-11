using System;
using System.Collections.Generic;

namespace Catalog.Domain
{
    public class Genre
    {
        /// <summary>
        /// Genre Id
        /// </summary>
        public Guid GenreId { get; set; }
        /// <summary>
        /// Genre Description
        /// </summary>
        public string GenreDescription { get; set; }
        /// <summary>
        /// Reference to list of albums of this genre
        /// </summary>
        public ICollection<Item> Items { get; set; }
    }
}