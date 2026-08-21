using System;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class Payroll
    {
        [Key]
        public int PayrollId { get; set; }

        public int EmployeeId { get; set; }

        public int SalaryStructureId { get; set; }

        public string PayMonth { get; set; }

        public decimal GrossSalary { get; set; }

        public decimal TotalDeductions { get; set; }

        public decimal NetSalary { get; set; }

        public DateOnly PaymentDate { get; set; }

        public string PaymentStatus { get; set; }
    }
}