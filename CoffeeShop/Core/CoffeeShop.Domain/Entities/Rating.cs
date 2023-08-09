using CoffeeShop.Domain.Entities.Common;
using CoffeeShop.Domain.Entities.Enums;

namespace CoffeeShop.Domain.Entities;

public class Rating  : BaseEntity
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public RatingEnum RatingLevel { get; set; }
    public AppUser User { get; set; }
    public Product Product { get; set; }
}
