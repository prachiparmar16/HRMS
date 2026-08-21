using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class UserRegistrationValidator : AbstractValidator<UserRegistration>
    {
        public UserRegistrationValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is required.");

            RuleFor(x => x.Gender)
                .NotEmpty()
                .WithMessage("Gender is required.");

            RuleFor(x => x.PersonalEmail)
                .NotEmpty()
                .WithMessage("Personal email is required.")
                .EmailAddress()
                .WithMessage("Enter a valid email address.");
        }
    }
}