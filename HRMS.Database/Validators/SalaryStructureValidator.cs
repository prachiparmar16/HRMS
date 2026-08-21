using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class SalaryStructureValidator : AbstractValidator<SalaryStructure>
    {
        public SalaryStructureValidator()
        {
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithMessage("Employee ID is required.");

            RuleFor(x => x.BasicSalary)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Basic salary cannot be negative.");

            RuleFor(x => x.HRA)
                .GreaterThanOrEqualTo(0)
                .WithMessage("HRA cannot be negative.");

            RuleFor(x => x.Allowances)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Allowances cannot be negative.");

            RuleFor(x => x.Deductions)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Deductions cannot be negative.");

            RuleFor(x => x.GrossSalary)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Gross salary cannot be negative.");

            RuleFor(x => x.NetSalary)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Net salary cannot be negative.");
        }
    }
}