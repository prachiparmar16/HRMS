using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class HolidayValidator : AbstractValidator<Holiday>
    {
        public HolidayValidator()
        {
            RuleFor(x => x.HolidayName)
                .NotEmpty()
                .WithMessage("Holiday name is required.")
                .MaximumLength(100)
                .WithMessage("Holiday name cannot exceed 100 characters.");

            RuleFor(x => x.HolidayDate)
                .NotEmpty()
                .WithMessage("Holiday date is required.");

            RuleFor(x => x.Description)
                .MaximumLength(500)
                .WithMessage("Description cannot exceed 500 characters.");
        }
    }
}