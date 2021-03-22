using Catalog.Domain.Entities;
using Catalog.Domain.Responses.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Mappers
{
    public class GenreMapper : IGenreMapper
    {
        public GenreResponse Map(Genre request)
        {
            if (request == null) return null;

            return new GenreResponse { 
                GenreId = request.GenreId,
                GenreDescription = request.GenreDescription 
            };
        }
    }
}
