using FluentValidation;
using PizzaManagement.API.Infrastructure.Localization;
using PizzaManagement.Application.Entities.AddressFolder;

namespace PizzaManagement.API.Infrastructure.Validators
{
    //because I trust my domains, I will only check validations for Post/Put
    public class AddressValidator : AbstractValidator<AddressRequestModel>
    {
        public AddressValidator()
        {
            RuleFor(x => x.UserId)
        .GreaterThan(0).WithMessage(ErrorMessages.UserNotFound);

            RuleFor(x => x.City)
                .NotEmpty().WithMessage(ErrorMessages.AddressCity)
                .MaximumLength(15).WithMessage(ErrorMessages.AddressCity);

            RuleFor(x => x.Country)
                .NotEmpty().WithMessage(ErrorMessages.AddressCountry)
                .MaximumLength(15).WithMessage(ErrorMessages.AddressCountry);

            RuleFor(x => x.Region)
                .NotEmpty().WithMessage(ErrorMessages.AddressRegion)
                .MaximumLength(15).WithMessage(ErrorMessages.AddressRegion);

            RuleFor(x => x.Description)
                .MaximumLength(100).WithMessage(ErrorMessages.AddressDescription);
        }
    }
}
