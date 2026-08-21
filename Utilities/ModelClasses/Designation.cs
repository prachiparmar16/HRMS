using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRMS.Models.ModelClasses
{
  public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
    }
}
