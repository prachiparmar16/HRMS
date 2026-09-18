using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IEmployeeMasterRepository
    {
        // =========================
        // DEPARTMENT
        // =========================

        Task<List<EmployeeDepartment>> GetDepartments();
        Task<EmployeeDepartment?> GetDepartmentById(int departmentId);
        Task<EmployeeDepartment> AddDepartment(EmployeeDepartment department);
        Task<EmployeeDepartment?> UpdateDepartment(EmployeeDepartment department);
        Task<bool> DeleteDepartment(int departmentId);


        // =========================
        // DESIGNATION
        // =========================

        Task<List<Designation>> GetDesignations();
        Task<Designation?> GetDesignationById(int designationId);
        Task<Designation> AddDesignation(Designation designation);
        Task<Designation?> UpdateDesignation(Designation designation);
        Task<bool> DeleteDesignation(int designationId);


        // =========================
        // JOB TITLE
        // =========================

        Task<List<JobTitle>> GetJobTitles();
        Task<JobTitle?> GetJobTitleById(int jobTitleId);
        Task<JobTitle> AddJobTitle(JobTitle jobTitle);
        Task<JobTitle?> UpdateJobTitle(JobTitle jobTitle);
        Task<bool> DeleteJobTitle(int jobTitleId);


        // =========================
        // GRADE
        // =========================

        Task<List<Grade>> GetGrades();
        Task<Grade?> GetGradeById(int gradeId);
        Task<Grade> AddGrade(Grade grade);
        Task<Grade?> UpdateGrade(Grade grade);
        Task<bool> DeleteGrade(int gradeId);


        // =========================
        // JOB LEVEL
        // =========================

        Task<List<JobLevel>> GetJobLevels();
        Task<JobLevel?> GetJobLevelById(int jobLevelId);
        Task<JobLevel> AddJobLevel(JobLevel jobLevel);
        Task<JobLevel?> UpdateJobLevel(JobLevel jobLevel);
        Task<bool> DeleteJobLevel(int jobLevelId);


        // =========================
        // EMPLOYMENT TYPE
        // =========================

        Task<List<EmploymentType>> GetEmploymentTypes();
        Task<EmploymentType?> GetEmploymentTypeById(int employmentTypeId);
        Task<EmploymentType> AddEmploymentType(EmploymentType employmentType);
        Task<EmploymentType?> UpdateEmploymentType(EmploymentType employmentType);
        Task<bool> DeleteEmploymentType(int employmentTypeId);


        // =========================
        // EMPLOYEE CATEGORY
        // =========================

        Task<List<EmployeeCategory>> GetEmployeeCategories();
        Task<EmployeeCategory?> GetEmployeeCategoryById(int employeeCategoryId);
        Task<EmployeeCategory> AddEmployeeCategory(EmployeeCategory employeeCategory);
        Task<EmployeeCategory?> UpdateEmployeeCategory(EmployeeCategory employeeCategory);
        Task<bool> DeleteEmployeeCategory(int employeeCategoryId);


        // =========================
        // SHIFT
        // =========================

        Task<List<Shift>> GetShifts();
        Task<Shift?> GetShiftById(int shiftId);
        Task<Shift> AddShift(Shift shift);
        Task<Shift?> UpdateShift(Shift shift);
        Task<bool> DeleteShift(int shiftId);


        // =========================
        // HOLIDAY
        // =========================

        Task<List<Holiday>> GetHolidays();
        Task<Holiday?> GetHolidayById(int holidayId);
        Task<Holiday> AddHoliday(Holiday holiday);
        Task<Holiday?> UpdateHoliday(Holiday holiday);
        Task<bool> DeleteHoliday(int holidayId);


        // =========================
        // LEAVE TYPE
        // =========================

        Task<List<LeaveType>> GetLeaveTypes();
        Task<LeaveType?> GetLeaveTypeById(int leaveTypeId);
        Task<LeaveType> AddLeaveType(LeaveType leaveType);
        Task<LeaveType?> UpdateLeaveType(LeaveType leaveType);
        Task<bool> DeleteLeaveType(int leaveTypeId);


        // =========================
        // LEAVE POLICY
        // =========================

        Task<List<LeavePolicy>> GetLeavePolicies();
        Task<LeavePolicy?> GetLeavePolicyById(int leavePolicyId);
        Task<LeavePolicy> AddLeavePolicy(LeavePolicy leavePolicy);
        Task<LeavePolicy?> UpdateLeavePolicy(LeavePolicy leavePolicy);
        Task<bool> DeleteLeavePolicy(int leavePolicyId);
    }
}