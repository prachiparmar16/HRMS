using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class EmployeeAddress
    {
        [Key]
        public int AddressId { get; set; }

        public int EmployeeId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string AddressType { get; set; }
    }
}