using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Certification
    {
        [Key]
        public int CertificationId { get; set; }

        [Required(ErrorMessage = "Certification name is required.")]
        [MaxLength(150, ErrorMessage = "Certification name cannot exceed 150 characters.")]
        public string CertificationName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}