using CoffeeShop.Domain.Entities;
using FluentValidation;

namespace CoffeeShop.Application.Validations;    

public class ProductValidator   : AbstractValidator<Product>
{
	public ProductValidator()
	{
		RuleFor(x=> x.Name).NotEmpty().WithMessage(" Name is required !");

	}
}
