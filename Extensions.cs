using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Name = item.Name,
                Price = item.Price,
                Id = item.Id,
                CreateDate = item.CreateDate
            };
        }
    }
}