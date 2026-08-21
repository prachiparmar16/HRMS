using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class UserLogin
    {
        [Key]
        public int EmployeeId { get; set; }
 
   
        public required string EmployeeEmail { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
