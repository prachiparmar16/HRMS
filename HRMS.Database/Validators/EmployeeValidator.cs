using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    
        public class EmployeeValidator : AbstractValidator<Employee>
        {
            public EmployeeValidator()
            {
                RuleFor(x => x.FirstName)
                    .NotEmpty()
                    .WithMessage("First name is required.")
                    .MaximumLength(50)
                    .WithMessage("First name cannot exceed 50 characters.");

                RuleFor(x => x.MiddleName)
                    .MaximumLength(50)
                    .WithMessage("Middle name cannot exceed 50 characters.");

                RuleFor(x => x.LastName)
                    .NotEmpty()
                    .WithMessage("Last name is required.")
                    .MaximumLength(50)
                    .WithMessage("Last name cannot exceed 50 characters.");

                RuleFor(x => x.Gender)
                    .NotEmpty()
                    .WithMessage("Gender is required.");

            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                    .WithMessage("Date of birth is required.")
                        .LessThan(DateOnly.FromDateTime(DateTime.Now))
                        .WithMessage("Date of birth must be in the past.");

            RuleFor(x => x.PersonalEmail)
                    .NotEmpty()
                    .WithMessage("Personal email is required.")
                    .EmailAddress()
                    .WithMessage("Enter a valid personal email address.");

                RuleFor(x => x.Contact)
                    .NotEmpty()
                    .WithMessage("Contact number is required.")
                    .Matches(@"^[0-9]{10}$")
                    .WithMessage("Contact number must contain exactly 10 digits.");

                RuleFor(x => x.CompanyEmail)
                    .EmailAddress()
                    .When(x => !string.IsNullOrWhiteSpace(x.CompanyEmail))
                    .WithMessage("Enter a valid company email address.");

                RuleFor(x => x.DepartmentId)
                    .GreaterThan(0)
                    .WithMessage("Department is required.");

                RuleFor(x => x.DesignationId)
                    .GreaterThan(0)
                    .WithMessage("Designation is required.");

                RuleFor(x => x.GradeId)
                    .GreaterThan(0)
                    .WithMessage("Grade is required.");

            RuleFor(x => x.DateOfJoining)
                    .NotEmpty()
                    .WithMessage("Date of joining is required.")
                    .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Today))
                    .WithMessage("Date of joining cannot be in the future.");

            RuleFor(x => x.EmploymentType)
                    .NotEmpty()
                    .WithMessage("Employment type is required.");

                RuleFor(x => x.EmployeeStatus)
                    .NotEmpty()
                    .WithMessage("Employee status is required.");
            }
        }
}