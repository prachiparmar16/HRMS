using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class AssetBrand
    {
        [Key]
        public int AssetBrandId { get; set; }

        [Required]
        [MaxLength(100)]
        public string BrandName { get; set; } = string.Empty;

        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}

