using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class BusinessUnit
    {
        [Key]
        public int BusinessUnitId { get; set; }

        [Required(ErrorMessage = "Business Unit name is required.")]
        [MaxLength(100, ErrorMessage = "Business Unit name cannot exceed 100 characters.")]
        public string BusinessUnitName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Company is required.")]
        public int CompanyId { get; set; }

        public bool IsActive { get; set; } = true;

        public Company Company { get; set; }
    }
}