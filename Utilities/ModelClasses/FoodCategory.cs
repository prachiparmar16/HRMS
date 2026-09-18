using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class FoodCategory
    {
        [Key]
        public int FoodCategoryId { get; set; }

        [Required(ErrorMessage = "Food category name is required.")]
        [MaxLength(100, ErrorMessage = "Food category name cannot exceed 100 characters.")]
        public string FoodCategoryName { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}