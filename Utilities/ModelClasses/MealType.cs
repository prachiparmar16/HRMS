using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class MealType
    {
        [Key]
        public int MealTypeId { get; set; }

        [Required(ErrorMessage = "Meal type is required.")]
        [MaxLength(100, ErrorMessage = "Meal type cannot exceed 100 characters.")]
        public string MealTypeName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}