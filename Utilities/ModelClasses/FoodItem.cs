using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }

        [Required(ErrorMessage = "Food item name is required.")]
        [MaxLength(100, ErrorMessage = "Food item name cannot exceed 100 characters.")]
        public string FoodItemName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Food category is required.")]
        public int FoodCategoryId { get; set; }

        public bool IsActive { get; set; } = true;

        public FoodCategory FoodCategory { get; set; }
    }
}