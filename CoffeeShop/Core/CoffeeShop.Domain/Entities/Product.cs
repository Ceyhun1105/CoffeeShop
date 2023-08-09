using CoffeeShop.Domain.Entities.Common;
using CoffeeShop.Domain.Entities.Enums;

namespace CoffeeShop.Domain.Entities;

public class Product : BaseEntity
{
    public int CategoryId { get; set; }

    public string Name { get; set; }
    public double SalePrice  { get; set; }
    public double CostPrice  { get; set; }
    public double DiscountPercent { get; set; } = 0;
    public string Description { get; set; }
    public CoffeeSizeEnum SizeCoffee { get; set; }
    public double SizeGram { get; set; } = 0;
    public int SaledCount { get; set; } = 0;


    public Category Category { get; set; }
    public List<Review> Reviews { get; set; }
    public List<Rating> Ratings { get; set; }
}


