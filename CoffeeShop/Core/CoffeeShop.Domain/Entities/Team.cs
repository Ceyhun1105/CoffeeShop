using CoffeeShop.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;

namespace CoffeeShop.Domain.Entities;

public class Team : BaseEntity
{
    public string Proffesional { get; set; }
    public string Desc { get; set; }
    public string ImageUrl { get; set; }
    public string FullName { get; set; }
    public IFormFile Image { get; set; }
}
