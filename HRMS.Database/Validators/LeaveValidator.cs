using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class LeaveValidator : AbstractValidator<Leave>
    {
        public LeaveValidator()
        {
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithMessage("Employee ID must be greater than 0.");

            RuleFor(x => x.LeaveType)
                .NotEmpty()
                .WithMessage("Leave type is required.");

            RuleFor(x => x.FromDate)
                .NotEmpty()
                .WithMessage("From date is required.");

            RuleFor(x => x.ToDate)
                .NotEmpty()
                .WithMessage("To date is required.")
                .GreaterThanOrEqualTo(x => x.FromDate)
                .WithMessage("To date must be greater than or equal to From date.");

            RuleFor(x => x.AppliedDate)
                .NotEmpty()
                .WithMessage("Applied date is required.");

            RuleFor(x => x.LeaveDays)
                .GreaterThan(0)
                .WithMessage("Leave days must be greater than 0.");

            RuleFor(x => x.Reason)
                .NotEmpty()
                .WithMessage("Reason is required.")
                .MaximumLength(500)
                .WithMessage("Reason cannot exceed 500 characters.");

            RuleFor(x => x.Status)
                .NotEmpty()
                .WithMessage("Leave status is required.");
        }
    }
}