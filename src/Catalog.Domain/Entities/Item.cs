using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Entities
{
    public class Item
    {
        /// <summary>
        /// Id of item
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Album's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Music album description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Music album release date
        /// </summary>
        public DateTimeOffset ReleaseDate { get; set; }
        /// <summary>
        /// Music album label
        /// </summary>
        public string LabelName { get; set; }
        /// <summary>
        /// An item's price.
        /// </summary>
        public Price Price { get; set; }
        /// <summary>
        /// Album's picture link
        /// </summary>
        public string PictureUri { get; set; }
        /// <summary>
        /// Music album format
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// Avialable stock
        /// </summary>
        public int AvailableStock { get; set; }
        /// <summary>
        /// Foriegn key for Genres table
        /// </summary>
        public Guid GenreId { get; set; }
        /// <summary>
        /// Music album genre
        /// </summary>
        public Genre Genre { get; set; }
        /// <summary>
        /// Forien-key for Artists table
        /// </summary>
        public Guid ArtistId { get; set; }
        /// <summary>
        /// Album's artist
        /// </summary>
        public Artist Artist { get; set; }

    }
}
