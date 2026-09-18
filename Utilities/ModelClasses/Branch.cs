using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }

        [Required(ErrorMessage = "Branch name is required.")]
        [MaxLength(100, ErrorMessage = "Branch name cannot exceed 100 characters.")]
        public string BranchName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Company is required.")]
        public int CompanyId { get; set; }

        public bool IsActive { get; set; } = true;

        public Company Company { get; set; }
    }
}