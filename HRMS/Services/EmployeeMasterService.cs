using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class EmployeeMasterService : IEmployeeMasterRepository
    {
        private readonly HrmsDbContext _db;

        public EmployeeMasterService(HrmsDbContext db)
        {
            _db = db;
        }

        // =========================
        // DEPARTMENT
        // =========================

        public async Task<List<EmployeeDepartment>> GetDepartments()
        {
            return await _db.EmployeeDepartmentstbl
                .ToListAsync();
        }

        public async Task<EmployeeDepartment?> GetDepartmentById(int departmentId)
        {
            return await _db.EmployeeDepartmentstbl
                .FirstOrDefaultAsync(x =>
                    x.DepartmentId == departmentId);
        }

        public async Task<EmployeeDepartment> AddDepartment(
            EmployeeDepartment department)
        {
            _db.EmployeeDepartmentstbl.Add(department);

            await _db.SaveChangesAsync();

            return department;
        }

        public async Task<EmployeeDepartment?> UpdateDepartment(
            EmployeeDepartment department)
        {
            var existingDepartment =
                await _db.EmployeeDepartmentstbl
                .FirstOrDefaultAsync(x =>
                    x.DepartmentId == department.DepartmentId);

            if (existingDepartment == null)
                return null;

            existingDepartment.DepartmentName =
                department.DepartmentName;

            await _db.SaveChangesAsync();

            return existingDepartment;
        }

        public async Task<bool> DeleteDepartment(int departmentId)
        {
            var department =
                await _db.EmployeeDepartmentstbl
                .FirstOrDefaultAsync(x =>
                    x.DepartmentId == departmentId);

            if (department == null)
                return false;

            _db.EmployeeDepartmentstbl.Remove(department);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // DESIGNATION
        // =========================

        public async Task<List<Designation>> GetDesignations()
        {
            return await _db.Designationstbl
                .ToListAsync();
        }

        public async Task<Designation?> GetDesignationById(int designationId)
        {
            return await _db.Designationstbl
                .FirstOrDefaultAsync(x =>
                    x.DesignationId == designationId);
        }

        public async Task<Designation> AddDesignation(
            Designation designation)
        {
            _db.Designationstbl.Add(designation);

            await _db.SaveChangesAsync();

            return designation;
        }

        public async Task<Designation?> UpdateDesignation(
            Designation designation)
        {
            var existingDesignation =
                await _db.Designationstbl
                .FirstOrDefaultAsync(x =>
                    x.DesignationId == designation.DesignationId);

            if (existingDesignation == null)
                return null;

            existingDesignation.DesignationName =
                designation.DesignationName;

            await _db.SaveChangesAsync();

            return existingDesignation;
        }

        public async Task<bool> DeleteDesignation(int designationId)
        {
            var designation =
                await _db.Designationstbl
                .FirstOrDefaultAsync(x =>
                    x.DesignationId == designationId);

            if (designation == null)
                return false;

            _db.Designationstbl.Remove(designation);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // JOB TITLE
        // =========================

        public async Task<List<JobTitle>> GetJobTitles()
        {
            return await _db.JobTitlestbl
                .ToListAsync();
        }

        public async Task<JobTitle?> GetJobTitleById(int jobTitleId)
        {
            return await _db.JobTitlestbl
                .FirstOrDefaultAsync(x =>
                    x.JobTitleId == jobTitleId);
        }

        public async Task<JobTitle> AddJobTitle(JobTitle jobTitle)
        {
            _db.JobTitlestbl.Add(jobTitle);

            await _db.SaveChangesAsync();

            return jobTitle;
        }

        public async Task<JobTitle?> UpdateJobTitle(JobTitle jobTitle)
        {
            var existingJobTitle =
                await _db.JobTitlestbl
                .FirstOrDefaultAsync(x =>
                    x.JobTitleId == jobTitle.JobTitleId);

            if (existingJobTitle == null)
                return null;

            existingJobTitle.JobTitleName =
                jobTitle.JobTitleName;

            existingJobTitle.IsActive =
                jobTitle.IsActive;

            await _db.SaveChangesAsync();

            return existingJobTitle;
        }

        public async Task<bool> DeleteJobTitle(int jobTitleId)
        {
            var jobTitle =
                await _db.JobTitlestbl
                .FirstOrDefaultAsync(x =>
                    x.JobTitleId == jobTitleId);

            if (jobTitle == null)
                return false;

            _db.JobTitlestbl.Remove(jobTitle);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // GRADE
        // =========================

        public async Task<List<Grade>> GetGrades()
        {
            return await _db.Gradestbl
                .ToListAsync();
        }

        public async Task<Grade?> GetGradeById(int gradeId)
        {
            return await _db.Gradestbl
                .FirstOrDefaultAsync(x =>
                    x.GradeId == gradeId);
        }

        public async Task<Grade> AddGrade(Grade grade)
        {
            _db.Gradestbl.Add(grade);

            await _db.SaveChangesAsync();

            return grade;
        }

        public async Task<Grade?> UpdateGrade(Grade grade)
        {
            var existingGrade =
                await _db.Gradestbl
                .FirstOrDefaultAsync(x =>
                    x.GradeId == grade.GradeId);

            if (existingGrade == null)
                return null;

            existingGrade.GradeName =
                grade.GradeName;

            await _db.SaveChangesAsync();

            return existingGrade;
        }

        public async Task<bool> DeleteGrade(int gradeId)
        {
            var grade =
                await _db.Gradestbl
                .FirstOrDefaultAsync(x =>
                    x.GradeId == gradeId);

            if (grade == null)
                return false;

            _db.Gradestbl.Remove(grade);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // JOB LEVEL
        // =========================

        public async Task<List<JobLevel>> GetJobLevels()
        {
            return await _db.JobLevelstbl
                .ToListAsync();
        }

        public async Task<JobLevel?> GetJobLevelById(int jobLevelId)
        {
            return await _db.JobLevelstbl
                .FirstOrDefaultAsync(x =>
                    x.JobLevelId == jobLevelId);
        }

        public async Task<JobLevel> AddJobLevel(JobLevel jobLevel)
        {
            _db.JobLevelstbl.Add(jobLevel);

            await _db.SaveChangesAsync();

            return jobLevel;
        }

        public async Task<JobLevel?> UpdateJobLevel(JobLevel jobLevel)
        {
            var existingJobLevel =
                await _db.JobLevelstbl
                .FirstOrDefaultAsync(x =>
                    x.JobLevelId == jobLevel.JobLevelId);

            if (existingJobLevel == null)
                return null;

            existingJobLevel.JobLevelName =
                jobLevel.JobLevelName;

            existingJobLevel.IsActive =
                jobLevel.IsActive;

            await _db.SaveChangesAsync();

            return existingJobLevel;
        }

        public async Task<bool> DeleteJobLevel(int jobLevelId)
        {
            var jobLevel =
                await _db.JobLevelstbl
                .FirstOrDefaultAsync(x =>
                    x.JobLevelId == jobLevelId);

            if (jobLevel == null)
                return false;

            _db.JobLevelstbl.Remove(jobLevel);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // EMPLOYMENT TYPE
        // =========================

        public async Task<List<EmploymentType>> GetEmploymentTypes()
        {
            return await _db.EmploymentTypestbl
                .ToListAsync();
        }

        public async Task<EmploymentType?> GetEmploymentTypeById(
            int employmentTypeId)
        {
            return await _db.EmploymentTypestbl
                .FirstOrDefaultAsync(x =>
                    x.EmploymentTypeId == employmentTypeId);
        }

        public async Task<EmploymentType> AddEmploymentType(
            EmploymentType employmentType)
        {
            _db.EmploymentTypestbl.Add(employmentType);

            await _db.SaveChangesAsync();

            return employmentType;
        }

        public async Task<EmploymentType?> UpdateEmploymentType(
            EmploymentType employmentType)
        {
            var existingEmploymentType =
                await _db.EmploymentTypestbl
                .FirstOrDefaultAsync(x =>
                    x.EmploymentTypeId ==
                    employmentType.EmploymentTypeId);

            if (existingEmploymentType == null)
                return null;

            existingEmploymentType.EmploymentTypeName =
                employmentType.EmploymentTypeName;

            existingEmploymentType.IsActive =
                employmentType.IsActive;

            await _db.SaveChangesAsync();

            return existingEmploymentType;
        }

        public async Task<bool> DeleteEmploymentType(
            int employmentTypeId)
        {
            var employmentType =
                await _db.EmploymentTypestbl
                .FirstOrDefaultAsync(x =>
                    x.EmploymentTypeId == employmentTypeId);

            if (employmentType == null)
                return false;

            _db.EmploymentTypestbl.Remove(employmentType);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // EMPLOYEE CATEGORY
        // =========================

        public async Task<List<EmployeeCategory>> GetEmployeeCategories()
        {
            return await _db.EmployeeCategorystbl
                .ToListAsync();
        }

        public async Task<EmployeeCategory?> GetEmployeeCategoryById(
            int employeeCategoryId)
        {
            return await _db.EmployeeCategorystbl
                .FirstOrDefaultAsync(x =>
                    x.EmployeeCategoryId == employeeCategoryId);
        }

        public async Task<EmployeeCategory> AddEmployeeCategory(
            EmployeeCategory employeeCategory)
        {
            _db.EmployeeCategorystbl.Add(employeeCategory);

            await _db.SaveChangesAsync();

            return employeeCategory;
        }

        public async Task<EmployeeCategory?> UpdateEmployeeCategory(
            EmployeeCategory employeeCategory)
        {
            var existingEmployeeCategory =
                await _db.EmployeeCategorystbl
                .FirstOrDefaultAsync(x =>
                    x.EmployeeCategoryId ==
                    employeeCategory.EmployeeCategoryId);

            if (existingEmployeeCategory == null)
                return null;

            existingEmployeeCategory.EmployeeCategoryName =
                employeeCategory.EmployeeCategoryName;

            existingEmployeeCategory.IsActive =
                employeeCategory.IsActive;

            await _db.SaveChangesAsync();

            return existingEmployeeCategory;
        }

        public async Task<bool> DeleteEmployeeCategory(
            int employeeCategoryId)
        {
            var employeeCategory =
                await _db.EmployeeCategorystbl
                .FirstOrDefaultAsync(x =>
                    x.EmployeeCategoryId == employeeCategoryId);

            if (employeeCategory == null)
                return false;

            _db.EmployeeCategorystbl.Remove(employeeCategory);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // SHIFT
        // =========================

        public async Task<List<Shift>> GetShifts()
        {
            return await _db.Shiftstbl
                .ToListAsync();
        }

        public async Task<Shift?> GetShiftById(int shiftId)
        {
            return await _db.Shiftstbl
                .FirstOrDefaultAsync(x =>
                    x.ShiftId == shiftId);
        }

        public async Task<Shift> AddShift(Shift shift)
        {
            _db.Shiftstbl.Add(shift);

            await _db.SaveChangesAsync();

            return shift;
        }

        public async Task<Shift?> UpdateShift(Shift shift)
        {
            var existingShift =
                await _db.Shiftstbl
                .FirstOrDefaultAsync(x =>
                    x.ShiftId == shift.ShiftId);

            if (existingShift == null)
                return null;

            existingShift.ShiftName =
                shift.ShiftName;

            existingShift.StartTime =
                shift.StartTime;

            existingShift.EndTime =
                shift.EndTime;

            existingShift.IsActive =
                shift.IsActive;

            await _db.SaveChangesAsync();

            return existingShift;
        }

        public async Task<bool> DeleteShift(int shiftId)
        {
            var shift =
                await _db.Shiftstbl
                .FirstOrDefaultAsync(x =>
                    x.ShiftId == shiftId);

            if (shift == null)
                return false;

            _db.Shiftstbl.Remove(shift);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // HOLIDAY
        // =========================

        public async Task<List<Holiday>> GetHolidays()
        {
            return await _db.Holidaystbl
                .ToListAsync();
        }

        public async Task<Holiday?> GetHolidayById(int holidayId)
        {
            return await _db.Holidaystbl
                .FirstOrDefaultAsync(x =>
                    x.HolidayId == holidayId);
        }

        public async Task<Holiday> AddHoliday(Holiday holiday)
        {
            _db.Holidaystbl.Add(holiday);

            await _db.SaveChangesAsync();

            return holiday;
        }

        public async Task<Holiday?> UpdateHoliday(Holiday holiday)
        {
            var existingHoliday =
                await _db.Holidaystbl
                .FirstOrDefaultAsync(x =>
                    x.HolidayId == holiday.HolidayId);

            if (existingHoliday == null)
                return null;

            existingHoliday.HolidayName =
                holiday.HolidayName;

            existingHoliday.HolidayDate =
                holiday.HolidayDate;

            await _db.SaveChangesAsync();

            return existingHoliday;
        }

        public async Task<bool> DeleteHoliday(int holidayId)
        {
            var holiday =
                await _db.Holidaystbl
                .FirstOrDefaultAsync(x =>
                    x.HolidayId == holidayId);

            if (holiday == null)
                return false;

            _db.Holidaystbl.Remove(holiday);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // LEAVE TYPE
        // =========================

        public async Task<List<LeaveType>> GetLeaveTypes()
        {
            return await _db.LeaveTypetbl
                .ToListAsync();
        }

        public async Task<LeaveType?> GetLeaveTypeById(int leaveTypeId)
        {
            return await _db.LeaveTypetbl
                .FirstOrDefaultAsync(x =>
                    x.LeaveTypeId == leaveTypeId);
        }

        public async Task<LeaveType> AddLeaveType(
            LeaveType leaveType)
        {
            _db.LeaveTypetbl.Add(leaveType);

            await _db.SaveChangesAsync();

            return leaveType;
        }

        public async Task<LeaveType?> UpdateLeaveType(
            LeaveType leaveType)
        {
            var existingLeaveType =
                await _db.LeaveTypetbl
                .FirstOrDefaultAsync(x =>
                    x.LeaveTypeId == leaveType.LeaveTypeId);

            if (existingLeaveType == null)
                return null;

            existingLeaveType.LeaveTypeName =
                leaveType.LeaveTypeName;

            await _db.SaveChangesAsync();

            return existingLeaveType;
        }

        public async Task<bool> DeleteLeaveType(int leaveTypeId)
        {
            var leaveType =
                await _db.LeaveTypetbl
                .FirstOrDefaultAsync(x =>
                    x.LeaveTypeId == leaveTypeId);

            if (leaveType == null)
                return false;

            _db.LeaveTypetbl.Remove(leaveType);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // LEAVE POLICY
        // =========================

        public async Task<List<LeavePolicy>> GetLeavePolicies()
        {
            return await _db.LeavePoliciestbl
                .Include(x => x.LeaveType)
                .ToListAsync();
        }

        public async Task<LeavePolicy?> GetLeavePolicyById(
            int leavePolicyId)
        {
            return await _db.LeavePoliciestbl
                .Include(x => x.LeaveType)
                .FirstOrDefaultAsync(x =>
                    x.LeavePolicyId == leavePolicyId);
        }

        public async Task<LeavePolicy> AddLeavePolicy(
            LeavePolicy leavePolicy)
        {
            _db.LeavePoliciestbl.Add(leavePolicy);

            await _db.SaveChangesAsync();

            return leavePolicy;
        }

        public async Task<LeavePolicy?> UpdateLeavePolicy(
            LeavePolicy leavePolicy)
        {
            var existingLeavePolicy =
                await _db.LeavePoliciestbl
                .FirstOrDefaultAsync(x =>
                    x.LeavePolicyId ==
                    leavePolicy.LeavePolicyId);

            if (existingLeavePolicy == null)
                return null;

            existingLeavePolicy.LeavePolicyName =
                leavePolicy.LeavePolicyName;

            existingLeavePolicy.LeaveTypeId =
                leavePolicy.LeaveTypeId;

            existingLeavePolicy.TotalDays =
                leavePolicy.TotalDays;

            existingLeavePolicy.IsActive =
                leavePolicy.IsActive;

            await _db.SaveChangesAsync();

            return existingLeavePolicy;
        }

        public async Task<bool> DeleteLeavePolicy(int leavePolicyId)
        {
            var leavePolicy =
                await _db.LeavePoliciestbl
                .FirstOrDefaultAsync(x =>
                    x.LeavePolicyId == leavePolicyId);

            if (leavePolicy == null)
                return false;

            _db.LeavePoliciestbl.Remove(leavePolicy);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}