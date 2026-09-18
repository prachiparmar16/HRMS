using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class EmployeeCategory
    {
        [Key]
        public int EmployeeCategoryId { get; set; }

        [Required(ErrorMessage = "Employee category is required.")]
        [MaxLength(100, ErrorMessage = "Employee category cannot exceed 100 characters.")]
        public string EmployeeCategoryName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}