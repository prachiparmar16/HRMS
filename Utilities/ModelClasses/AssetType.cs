using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public  class AssetType
    {
        [Key]
        public int AssetTypeId { get; set; }

        [Required(ErrorMessage = "Asset type name is required.")]
        [StringLength(100, MinimumLength = 2,
       ErrorMessage = "Asset type name must be between 2 and 100 characters.")]
        public string AssetTypeName { get; set; } = string.Empty;

        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters.")]
        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}

