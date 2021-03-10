using System;

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
    }
}