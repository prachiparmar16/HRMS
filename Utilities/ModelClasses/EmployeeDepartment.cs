using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class EmployeeDepartment
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        [MaxLength(100, ErrorMessage = "Department name cannot exceed 100 characters.")]
        public string DepartmentName { get; set; } = string.Empty;
    }
}