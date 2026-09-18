using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class RecruitmentSource
    {
        [Key]
        public int RecruitmentSourceId { get; set; }

        [Required(ErrorMessage = "Recruitment source is required.")]
        [MaxLength(100, ErrorMessage = "Recruitment source cannot exceed 100 characters.")]
        public string RecruitmentSourceName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}