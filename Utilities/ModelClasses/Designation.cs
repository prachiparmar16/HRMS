using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }

        [Required(ErrorMessage = "Designation name is required.")]
        [MaxLength(100, ErrorMessage = "Designation name cannot exceed 100 characters.")]
        public string DesignationName { get; set; } = string.Empty;
    }
}