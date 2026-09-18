using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class DocumentType
    {
        [Key]
        public int DocumentTypeId { get; set; }

        [Required]
        [MaxLength(255)]
        public string DocumentTypeName { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
