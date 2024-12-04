using FluentValidation;
using Pet_Shop.Classes.Products;

namespace Pet_Shop.Classes.Validators
{
    internal class DogLeashValidator : AbstractValidator<DogLeash>
    {
        public DogLeashValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Price).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Quantity).GreaterThanOrEqualTo(0);
            RuleFor(x => x.Description).MinimumLength(10).When(x => !string.IsNullOrEmpty(x.Description));
        }
    }
}
