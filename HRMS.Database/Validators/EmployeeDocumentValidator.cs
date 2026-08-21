using FluentValidation;
using HRMS.Models.ModelClasses;

namespace HRMS.Database.Validators
{
    public class EmployeeDocumentValidator : AbstractValidator<EmployeeDocument>
    {
        public EmployeeDocumentValidator()
        {
            RuleFor(x => x.EmployeeId)
                .GreaterThan(0)
                .WithMessage("Employee ID is required.");

            RuleFor(x => x.DocumentType)
                .NotEmpty()
                .WithMessage("Document type is required.");

            RuleFor(x => x.DocumentName)
                .NotEmpty()
                .WithMessage("Document name is required.")
                .MaximumLength(200)
                .WithMessage("Document name cannot exceed 200 characters.");

            RuleFor(x => x.DocumentPath)
                .NotEmpty()
                .WithMessage("Document path is required.");

            RuleFor(x => x.UploadedDate)
                .NotEmpty()
                .WithMessage("Uploaded date is required.");

            RuleFor(x => x.Status)
                .NotEmpty()
                .WithMessage("Document status is required.");
        }
    }
}