using CoffeeShop.Domain.Entities.Common;
using Microsoft.AspNetCore.Http;

namespace CoffeeShop.Domain.Entities;

public class Slider  : BaseEntity
{
    public string Title { get; set; }
    public string Desc1 { get; set; }
    public string Desc2 { get; set; }
    public string ButtonUrl { get; set; }
    public string ButtonTitle { get; set; }
    public string Image1Url { get; set; }
    public string Image2Url { get; set; }
    public string Image3Url { get; set; }
    public bool? IsSlider { get; set; }


    public IFormFile? Image1 { get; set; }
    public IFormFile? Image2 { get; set; }
    public IFormFile? Image3 { get; set; }


}
