using CoffeeShop.Domain.Entities.Common;

namespace CoffeeShop.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}
