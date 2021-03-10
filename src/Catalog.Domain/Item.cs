using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain
{
    public class Item
    {
        /// <summary>
        /// Id of item
        /// </summary>
        public Guid Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Music album description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Music album release date
        /// </summary>
        public string ReleaseDate { get; set; }
        /// <summary>
        /// Music album label
        /// </summary>
        public string LabelName { get; set; }
        /// <summary>
        /// An item's price.
        /// </summary>
        public Price Price { get; set; }
        /// <summary>
        /// Music album format
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// Avialable stock
        /// </summary>
        public int AvailableStock { get; set; }
        /// <summary>
        /// Music album genre
        /// </summary>
        public Genre Genre { get; set; }
        /// <summary>
        /// Album's artist
        /// </summary>
        public Artist Artist { get; set; }

    }
}
