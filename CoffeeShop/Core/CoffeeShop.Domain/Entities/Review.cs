using CoffeeShop.Domain.Entities.Common;
using System.Security.Principal;

namespace CoffeeShop.Domain.Entities;

public class Review : BaseEntity
{
    public int ProductId { get; set; }
    public int UserId { get; set; }


    public string Content { get; set; }
    public int LikedCount { get; set; }
    public int PinnedCount { get; set; }


    public AppUser? User { get; set; }
    public Product? Product { get; set; }
}
