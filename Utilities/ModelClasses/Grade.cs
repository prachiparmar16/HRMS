using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }

        [Required(ErrorMessage = "Grade name is required.")]
        [MaxLength(100, ErrorMessage = "Grade name cannot exceed 100 characters.")]
        public string GradeName { get; set; } = string.Empty;
    }
}