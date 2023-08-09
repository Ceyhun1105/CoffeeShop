using CoffeeShop.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;

namespace CoffeeShop.Domain.Entities;

public class History : BaseEntity
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public string Image1Url { get; set; }
    public string Image2Url { get; set; }
    public IFormFile Image1 { get; set; }
    public IFormFile Image2 { get; set; }
}
