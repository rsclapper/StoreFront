using FluentValidation;
using StoreFront.Application.Commands.CreateProduct;

namespace StoreFront.Application.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(command => command.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .Length(2, 100).WithMessage("Product name must be between 2 and 100 characters.");

            RuleFor(command => command.Description)
                .NotEmpty().WithMessage("Product description is required.");

            RuleFor(command => command.Price)
                .GreaterThan(0).WithMessage("Product price must be greater than zero.");

            // If ReleaseDate is provided, it should not be in the future. You can adjust this rule as needed.
            RuleFor(command => command.ReleaseDate)
                .LessThanOrEqualTo(System.DateTime.Today).When(command => command.ReleaseDate.HasValue)
                .WithMessage("Product release date cannot be in the future.");
        }
    }
}