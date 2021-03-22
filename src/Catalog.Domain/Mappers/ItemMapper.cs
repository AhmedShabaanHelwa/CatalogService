using Catalog.Domain.Entities;
using Catalog.Domain.Requests.Item;
using Catalog.Domain.Responses.Item;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Mappers
{
    public class ItemMapper : IItemMapper
    {
        private readonly IArtistMapper _artistMapper;
        private readonly IGenreMapper  _genreMapper;
        public ItemMapper(IArtistMapper artistMapper, IGenreMapper genreMapper)
        {
            _artistMapper = artistMapper;
            _genreMapper = genreMapper;
        }
        /// <summary>
        /// Manual mapping of AddItemRequest to Item entity
        /// </summary>
        /// <param name="request">Add item request DTO</param>
        /// <returns>Item entity instance</returns>
        public Item Map(AddItemRequest request)
        {
            // Null checking
            if (request == null) return null;
            // Mapping the request
            var item = new Item
            { 
                Name = request.Name,
                Description = request.Description,
                LabelName = request.LabelName,
                PictureUri = request.PictureUri,
                ReleaseDate = request.ReleaseDate,
                Format = request.Format,
                AvailableStock = request.AvailableStock,
                GenreId = request.GenreId,
                ArtistId = request.ArtistId
            };
            // Set the price
            if (request.Price != null)
            {
                item.Price = new Price { Amount = request.Price.Amount, Currency = request.Price.Currency };
            }

            return item;
        }

        public Item Map(EditItemRequest request)
        {
            // Null checking
            if (request == null) return null;
            // Mapping the request
            var item = new Item
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                LabelName = request.LabelName,
                PictureUri = request.PictureUri,
                ReleaseDate = request.ReleaseDate,
                Format = request.Format,
                AvailableStock = request.AvailableStock,
                GenreId = request.GenreId,
                ArtistId = request.ArtistId
            };

            if (request.Price != null)
            {
                item.Price = new Price { Amount = request.Price.Amount, Currency = request.Price.Currency };
            }

            return item;
        }

        public ItemResponse Map(Item request)
        {
            // Null checking
            if (request == null) return null;
            // Mapping response
            var itemResponse = new ItemResponse 
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                LabelName = request.LabelName,
                PictureUri = request.PictureUri,
                ReleaseDate = request.ReleaseDate,
                AvailableStock = request.AvailableStock,
                Genre = _genreMapper.Map(request.Genre),
                GenreId = request.GenreId,
                Artist = _artistMapper.Map(request.Artist),
                ArtistId =  request.ArtistId,
                Format = request.Format
            };

            if (request.Price != null)
                itemResponse.Price = new Price { Amount = request.Price.Amount, Currency = request.Price.Currency };

            return itemResponse;
        }
    }
}
