using CoffeeShop.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;

namespace CoffeeShop.Domain.Entities;

public class Gallery : BaseEntity
{
    public string ImageUrl { get; set; }
    public IFormFile Image { get; set; }
}
