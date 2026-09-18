using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class CostCenter
    {
        [Key]
        public int CostCenterId { get; set; }

        [Required(ErrorMessage = "Cost Center name is required.")]
        [MaxLength(100, ErrorMessage = "Cost Center name cannot exceed 100 characters.")]
        public string CostCenterName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Company is required.")]
        public int CompanyId { get; set; }

        public bool IsActive { get; set; } = true;

        public Company Company { get; set; }
    }
}