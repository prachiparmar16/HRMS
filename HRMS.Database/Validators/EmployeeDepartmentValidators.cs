using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class EmployeeDepartmentValidator : AbstractValidator<EmployeeDepartment>
    {
        public EmployeeDepartmentValidator()
        {
            RuleFor(x => x.DepartmentName)
                .NotEmpty()
                .WithMessage("Department name is required.")
                .MaximumLength(100)
                .WithMessage("Department name cannot exceed 100 characters.");
        }
    }
}