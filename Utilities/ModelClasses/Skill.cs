using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        [Required(ErrorMessage = "Skill name is required.")]
        [MaxLength(100, ErrorMessage = "Skill name cannot exceed 100 characters.")]
        public string SkillName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}