using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class MealPlan
    {
        [Key]
        public int MealPlanId { get; set; }

        [Required(ErrorMessage = "Meal plan name is required.")]
        [MaxLength(100, ErrorMessage = "Meal plan name cannot exceed 100 characters.")]
        public string MealPlanName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Meal type is required.")]
        public int MealTypeId { get; set; }

        public bool IsActive { get; set; } = true;

        public MealType MealType { get; set; }
    }
}
