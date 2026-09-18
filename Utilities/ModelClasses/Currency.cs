using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
    public class Currency
    {
        [Key]
        public int CurrencyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CurrencyName { get; set; } = string.Empty;

        [Required]
        [MaxLength (100)]
        public string CurrencyCode { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
