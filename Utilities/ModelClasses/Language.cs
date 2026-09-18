using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [Required]
        [MaxLength(255)]
        public string LanguageName { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
