using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class PayrollValidator : AbstractValidator<Payroll>
    {
        public PayrollValidator()
        {
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithMessage("Employee ID is required.");

            RuleFor(x => x.SalaryStructureId)
                .GreaterThan(0)
                .WithMessage("Salary structure is required.");

            RuleFor(x => x.PayMonth)
                .NotEmpty()
                .WithMessage("Pay month is required.");

            RuleFor(x => x.GrossSalary)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Gross salary cannot be negative.");

            RuleFor(x => x.TotalDeductions)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Total deductions cannot be negative.");

            RuleFor(x => x.NetSalary)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Net salary cannot be negative.");

            RuleFor(x => x.PaymentDate)
                .NotEmpty()
                .WithMessage("Payment date is required.");

            RuleFor(x => x.PaymentStatus)
                .NotEmpty()
                .WithMessage("Payment status is required.");
        }
    }
}