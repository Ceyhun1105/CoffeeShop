namespace CoffeeShop.Domain.Entities;
public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser
{
    public string? Adress { get; set; }
    public DateTime? BirthDay { get; set; }
    public List<Review>? Reviews { get; set; }
    public List<Rating>? Ratings { get; set; }
}
