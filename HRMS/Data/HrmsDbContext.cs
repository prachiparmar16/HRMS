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
        // Authentication
        public DbSet<UserLogin> UserLogintbl { get; set; }
        public DbSet<UserRegistration> UserRegistrationstbl { get; set; }

        // Employee Management
        public DbSet<Employee> Employeestbl { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartmentstbl { get; set; }
        public DbSet<Designation> Designationstbl { get; set; }
        public DbSet<Grade> Gradestbl { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocumentstbl { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddressestbl { get; set; }

        // Operations & Compensation
        public DbSet<Attendance> Attendancetbl { get; set; }
        public DbSet<Leave> Leavestbl { get; set; }
        public DbSet<LeaveType> LeaveTypetbl { get; set; }
        public DbSet<Holiday> Holidaystbl { get; set; }
        public DbSet<Payroll> Payrollstbl { get; set; }
        public DbSet<SalaryStructure> SalaryStructurestbl { get; set; }

        // Organization / Company Masters
        public DbSet<Company> Companiestbl { get; set; }
        public DbSet<BusinessUnit> BusinessUnitstbl { get; set; }
        public DbSet<Branch> Branchestbl { get; set; }
        public DbSet<CostCenter> CostCenterstbl { get; set; }
        public DbSet<Location> Locationstbl { get; set; }

        // Employee / HR Masters
        public DbSet<JobTitle> JobTitlestbl { get; set; }
        public DbSet<JobLevel> JobLevelstbl { get; set; }
        public DbSet<EmploymentType> EmploymentTypestbl { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategorystbl { get; set; }
        public DbSet<Shift> Shiftstbl { get; set; }
        public DbSet<LeavePolicy> LeavePoliciestbl { get; set; }
        // Recruitment / Talent Masters
        public DbSet<Skill> Skillstbl { get; set; }
        public DbSet<Qualification> Qualificationstbl { get; set; }
        public DbSet<Certification> Certificationstbl { get; set; }
        public DbSet<JobType> JobTypestbl { get; set; }
        public DbSet<InterviewType> InterviewTypestbl { get; set; }
        public DbSet<InterviewStatus> InterviewStatustbl { get; set; }
        public DbSet<RecruitmentSource> RecruitmentSourcetbl { get; set; }
        // Canteen Masters
        public DbSet<FoodCategory> FoodCategorystbl { get; set; }
        public DbSet<FoodItem> FoodItemstbl { get; set; }
        public DbSet<MealType> MealTypestbl { get; set; }
        public DbSet<Canteen> Canteentbl { get; set; }
        public DbSet<MealPlan> MealPlanstbl { get; set; }
    }
}