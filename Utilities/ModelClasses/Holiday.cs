using System;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Holiday
    {
        [Key]
        public int HolidayId { get; set; }

        public string HolidayName { get; set; }

        public DateOnly HolidayDate { get; set; }

        public string Description { get; set; }

        public bool IsOptional { get; set; }
    }
}