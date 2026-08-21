using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class AttendanceValidator : AbstractValidator<Attendance>
    {
        public AttendanceValidator()
        {
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithMessage("Employee ID is required.");

            RuleFor(x => x.AttendanceDate)
                .NotEmpty()
                .WithMessage("Attendance date is required.");

            RuleFor(x => x.Status)
                .NotEmpty()
                .WithMessage("Attendance status is required.");

            RuleFor(x => x.CheckOutTime)
                .GreaterThan(x => x.CheckInTime)
                .When(x => x.CheckInTime.HasValue && x.CheckOutTime.HasValue)
                .WithMessage("Check-out time must be after check-in time.");

            RuleFor(x => x.Remarks)
                .MaximumLength(500)
                .WithMessage("Remarks cannot exceed 500 characters.");
        }
    }
}