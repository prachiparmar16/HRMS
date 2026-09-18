using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class RelationshipType
    {
        [Key]
        public int RelationshipTypeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string RelationshipName { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
