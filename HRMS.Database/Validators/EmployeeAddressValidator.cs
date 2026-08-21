using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class EmployeeAddressValidator : AbstractValidator<EmployeeAddress>
    {
        public EmployeeAddressValidator()
        {
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithMessage("Employee ID is required.");

            RuleFor(x => x.AddressLine1)
                .NotEmpty()
                .WithMessage("Address is required.")
                .MaximumLength(200)
                .WithMessage("Address cannot exceed 200 characters.");

            RuleFor(x => x.AddressLine2)
                .MaximumLength(200)
                .WithMessage("Address cannot exceed 200 characters.");

            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("City is required.");

            RuleFor(x => x.State)
                .NotEmpty()
                .WithMessage("State is required.");

            RuleFor(x => x.Country)
                .NotEmpty()
                .WithMessage("Country is required.");

            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .WithMessage("Postal code is required.")
                .Matches(@"^[0-9]{6}$")
                .WithMessage("Postal code must contain 6 digits.");

            RuleFor(x => x.AddressType)
                .NotEmpty()
                .WithMessage("Address type is required.");
        }
    }
}