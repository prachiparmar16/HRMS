using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HRMS.Models.ModelClasses;
using Route = HRMS.Models.ModelClasses.Route;

namespace HRMS.WebAPI.Data
{
    public class HrmsDbContext : DbContext
    {
        internal object AllowanceTypestbl;

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
        public DbSet<SalaryComponent> SalaryComponentstbl { get; set; }
        public DbSet<SalaryGrade>SalaryGradestbl { get; set; }
        public DbSet<TaxSlab> TaxSlabstbl { get; set; }
        public DbSet<PayFrequency> PayFrequencytbl { get; set; }
        public DbSet<PayrollPolicy> PayrollPolicytbl { get; set; }
        public DbSet<DeductionType> DeductionTypetbl { get; set; }
        public DbSet<AllowanceType> AllowanceTypetbl { get; set; }
        public DbSet<AssetType> AssetTypetbl { get; set; }
        public DbSet<AssetCategory> AssetCategorytbl { get; set; }
        public DbSet<AssetStatus> AssetStatustbl { get; set; }
        public DbSet<AssetBrand> AssetBrandtbl { get; set; }
       
        public DbSet<SoftwareType> SoftwareTypetbl { get; set; }
        public DbSet<HardwareType> HardwareTypetbl { get; set; }
        public DbSet<VehicleType> VehicleTypetbl { get; set; }
        public DbSet<Vehicle>Vehicletbl { get; set; }
        public DbSet<PickupPoint> PickupPointtbl {  get; set; }
        public DbSet<Driver>Drivertbl { get; set; }
        public DbSet<Route> Routetbl { get; set; }
        public DbSet<Country> Countrytbl { get; set; }
        public DbSet<State> Statetbl { get; set; }
        public DbSet<City> Citytbl { get; set; }
        public DbSet<Currency> Currencytbl { get; set; }
        public DbSet<Language> Languagetbl { get; set; }
        public DbSet<Gender> Gendertbl { get; set; }
        public DbSet<BloodGroup> BloodGrouptbl { get; set; }
        public DbSet<MaritalStatus> MaritalStatustbl { get; set; }
        public DbSet<DocumentType> DocumentTypetbl { get; set; }
        public DbSet<RelationshipType> RelationshipTypetbl { get; set; }


    }
}