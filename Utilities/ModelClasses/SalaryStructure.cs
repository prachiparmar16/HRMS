using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class SalaryStructure
    {
        [Key]
        public int SalaryStructureId { get; set; }

        public int EmployeeId { get; set; }

        public decimal BasicSalary { get; set; }

        public decimal HRA { get; set; }

        public decimal Allowances { get; set; }

        public decimal Deductions { get; set; }

        public decimal GrossSalary { get; set; }

        public decimal NetSalary { get; set; }
    }
}