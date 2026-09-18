using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Company name is required.")]
        [MaxLength(100, ErrorMessage = "Company name cannot exceed 100 characters.")]
        public string CompanyName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}