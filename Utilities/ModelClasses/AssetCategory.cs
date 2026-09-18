using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class AssetCategory
    {
        [Key] 
        public int AssetCategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; } = string.Empty;
        [Required]
        [MaxLength (100)]
        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }

}