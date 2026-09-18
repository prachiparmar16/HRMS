using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
  public class TaxSlab
    {
        [Key]
        public int TaxSlabId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SlabName { get; set; } = string.Empty;

        public decimal MinimumIncome { get; set; }

        public decimal MaximumIncome { get; set; }

        public decimal TaxPercentage { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

