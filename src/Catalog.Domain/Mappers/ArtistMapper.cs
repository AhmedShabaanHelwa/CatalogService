using Catalog.Domain.Entities;
using Catalog.Domain.Responses.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Mappers
{
    public class ArtistMapper : IArtistMapper
    {
        public ArtistResponse Map(Artist request)
        {
            // Null checking
            if (request == null) return null;
            // Map the artist request DTO
            return new ArtistResponse { ArtistId = request.ArtistId, ArtistName = request.ArtistName };
        }
    }
}
