using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Data
{
    public class HrmsDbContext : DbContext
    {
        public HrmsDbContext(DbContextOptions<HrmsDbContext> options) : base(options) { }
        public DbSet<UserLogin> UserLogintbl { get; set; }
        public DbSet<UserRegistration> UserRegistrationstbl { get; set; }
        public DbSet<Employee> Employeestbl { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartmentstbl { get; set; }
        public DbSet<Designation> Designationstbl { get; set; }
        public DbSet<Grade> Gradestbl { get; set; }
        public DbSet<Leave> Leavestbl { get; set; }
        public DbSet<LeaveType> LeaveTypetbl { get; set; }
        public DbSet<Attendance> Attendancetbl { get; set; }
        public DbSet<Holiday> Holidaystbl { get; set; }
        public DbSet<Payroll> Payrollstbl { get; set; }
        public DbSet<SalaryStructure> SalaryStructurestbl { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocumentstbl { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddressestbl { get; set; }
    }
}