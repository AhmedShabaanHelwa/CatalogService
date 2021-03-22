using Catalog.Domain.Entities;
using Catalog.Domain.Responses.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Mappers
{
    public interface IGenreMapper
    {
        GenreResponse Map(Genre request);
    }
}
