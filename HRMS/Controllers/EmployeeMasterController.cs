using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeMasterController : ControllerBase
    {
        private readonly IEmployeeMasterRepository _service;

        public EmployeeMasterController(IEmployeeMasterRepository service)
        {
            _service = service;
        }

        // ==================== DEPARTMENT ====================

        [HttpGet("departments")]
        public async Task<IActionResult> GetDepartments()
        {
            return Ok(await _service.GetDepartments());
        }

        [HttpGet("department/{id}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var department = await _service.GetDepartmentById(id);

            if (department == null)
                return NotFound("Department not found.");

            return Ok(department);
        }

        [HttpPost("department")]
        public async Task<IActionResult> AddDepartment(EmployeeDepartment department)
        {
            var exists = (await _service.GetDepartments())
                .Any(x => x.DepartmentName.Trim().ToLower()
                            == department.DepartmentName.Trim().ToLower());

            if (exists)
                return Conflict("Department already exists.");

            var result = await _service.AddDepartment(department);

            return Ok(result);
        }

        [HttpPut("department/{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, EmployeeDepartment department)
        {
            var existing = await _service.GetDepartmentById(id);

            if (existing == null)
                return NotFound("Department not found.");

            var duplicate = (await _service.GetDepartments())
                .Any(x => x.DepartmentId != id &&
                         x.DepartmentName.Trim().ToLower()
                            == department.DepartmentName.Trim().ToLower());

            if (duplicate)
                return Conflict("Department already exists.");

            existing.DepartmentName = department.DepartmentName;

            var result = await _service.UpdateDepartment(existing);

            return Ok(result);
        }

        [HttpDelete("department/{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var existing = await _service.GetDepartmentById(id);

            if (existing == null)
                return NotFound("Department not found.");

            await _service.DeleteDepartment(id);

            return Ok("Department deleted successfully.");
        }


        // ==================== DESIGNATION ====================

        [HttpGet("designations")]
        public async Task<IActionResult> GetDesignations()
        {
            return Ok(await _service.GetDesignations());
        }

        [HttpGet("designation/{id}")]
        public async Task<IActionResult> GetDesignationById(int id)
        {
            var designation = await _service.GetDesignationById(id);

            if (designation == null)
                return NotFound("Designation not found.");

            return Ok(designation);
        }

        [HttpPost("designation")]
        public async Task<IActionResult> AddDesignation(Designation designation)
        {
            var exists = (await _service.GetDesignations())
                .Any(x => x.DesignationName.Trim().ToLower()
                            == designation.DesignationName.Trim().ToLower());

            if (exists)
                return Conflict("Designation already exists.");

            var result = await _service.AddDesignation(designation);

            return Ok(result);
        }

        [HttpPut("designation/{id}")]
        public async Task<IActionResult> UpdateDesignation(int id, Designation designation)
        {
            var existing = await _service.GetDesignationById(id);

            if (existing == null)
                return NotFound("Designation not found.");

            var duplicate = (await _service.GetDesignations())
                .Any(x => x.DesignationId != id &&
                         x.DesignationName.Trim().ToLower()
                            == designation.DesignationName.Trim().ToLower());

            if (duplicate)
                return Conflict("Designation already exists.");

            existing.DesignationName = designation.DesignationName;

            var result = await _service.UpdateDesignation(existing);

            return Ok(result);
        }

        [HttpDelete("designation/{id}")]
        public async Task<IActionResult> DeleteDesignation(int id)
        {
            var existing = await _service.GetDesignationById(id);

            if (existing == null)
                return NotFound("Designation not found.");

            await _service.DeleteDesignation(id);

            return Ok("Designation deleted successfully.");
        }


        // ==================== JOB TITLE ====================

        [HttpGet("job-titles")]
        public async Task<IActionResult> GetJobTitles()
        {
            return Ok(await _service.GetJobTitles());
        }

        [HttpGet("job-title/{id}")]
        public async Task<IActionResult> GetJobTitleById(int id)
        {
            var jobTitle = await _service.GetJobTitleById(id);

            if (jobTitle == null)
                return NotFound("Job Title not found.");

            return Ok(jobTitle);
        }

        [HttpPost("job-title")]
        public async Task<IActionResult> AddJobTitle(JobTitle jobTitle)
        {
            var exists = (await _service.GetJobTitles())
                .Any(x => x.JobTitleName.Trim().ToLower()
                            == jobTitle.JobTitleName.Trim().ToLower());

            if (exists)
                return Conflict("Job Title already exists.");

            var result = await _service.AddJobTitle(jobTitle);

            return Ok(result);
        }

        [HttpPut("job-title/{id}")]
        public async Task<IActionResult> UpdateJobTitle(int id, JobTitle jobTitle)
        {
            var existing = await _service.GetJobTitleById(id);

            if (existing == null)
                return NotFound("Job Title not found.");

            var duplicate = (await _service.GetJobTitles())
                .Any(x => x.JobTitleId != id &&
                         x.JobTitleName.Trim().ToLower()
                            == jobTitle.JobTitleName.Trim().ToLower());

            if (duplicate)
                return Conflict("Job Title already exists.");

            existing.JobTitleName = jobTitle.JobTitleName;
            existing.IsActive = jobTitle.IsActive;

            var result = await _service.UpdateJobTitle(existing);

            return Ok(result);
        }

        [HttpDelete("job-title/{id}")]
        public async Task<IActionResult> DeleteJobTitle(int id)
        {
            var existing = await _service.GetJobTitleById(id);

            if (existing == null)
                return NotFound("Job Title not found.");

            await _service.DeleteJobTitle(id);

            return Ok("Job Title deleted successfully.");
        }


        // ==================== GRADE ====================

        [HttpGet("grades")]
        public async Task<IActionResult> GetGrades()
        {
            return Ok(await _service.GetGrades());
        }

        [HttpGet("grade/{id}")]
        public async Task<IActionResult> GetGradeById(int id)
        {
            var grade = await _service.GetGradeById(id);

            if (grade == null)
                return NotFound("Grade not found.");

            return Ok(grade);
        }

        [HttpPost("grade")]
        public async Task<IActionResult> AddGrade(Grade grade)
        {
            var exists = (await _service.GetGrades())
                .Any(x => x.GradeName.Trim().ToLower()
                            == grade.GradeName.Trim().ToLower());

            if (exists)
                return Conflict("Grade already exists.");

            var result = await _service.AddGrade(grade);

            return Ok(result);
        }

        [HttpPut("grade/{id}")]
        public async Task<IActionResult> UpdateGrade(int id, Grade grade)
        {
            var existing = await _service.GetGradeById(id);

            if (existing == null)
                return NotFound("Grade not found.");

            var duplicate = (await _service.GetGrades())
                .Any(x => x.GradeId != id &&
                         x.GradeName.Trim().ToLower()
                            == grade.GradeName.Trim().ToLower());

            if (duplicate)
                return Conflict("Grade already exists.");

            existing.GradeName = grade.GradeName;

            var result = await _service.UpdateGrade(existing);

            return Ok(result);
        }

        [HttpDelete("grade/{id}")]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            var existing = await _service.GetGradeById(id);

            if (existing == null)
                return NotFound("Grade not found.");

            await _service.DeleteGrade(id);

            return Ok("Grade deleted successfully.");
        }


        // ==================== JOB LEVEL ====================

        [HttpGet("job-levels")]
        public async Task<IActionResult> GetJobLevels()
        {
            return Ok(await _service.GetJobLevels());
        }

        [HttpGet("job-level/{id}")]
        public async Task<IActionResult> GetJobLevelById(int id)
        {
            var jobLevel = await _service.GetJobLevelById(id);

            if (jobLevel == null)
                return NotFound("Job Level not found.");

            return Ok(jobLevel);
        }

        [HttpPost("job-level")]
        public async Task<IActionResult> AddJobLevel(JobLevel jobLevel)
        {
            var exists = (await _service.GetJobLevels())
                .Any(x => x.JobLevelName.Trim().ToLower()
                            == jobLevel.JobLevelName.Trim().ToLower());

            if (exists)
                return Conflict("Job Level already exists.");

            var result = await _service.AddJobLevel(jobLevel);

            return Ok(result);
        }

        [HttpPut("job-level/{id}")]
        public async Task<IActionResult> UpdateJobLevel(int id, JobLevel jobLevel)
        {
            var existing = await _service.GetJobLevelById(id);

            if (existing == null)
                return NotFound("Job Level not found.");

            var duplicate = (await _service.GetJobLevels())
                .Any(x => x.JobLevelId != id &&
                         x.JobLevelName.Trim().ToLower()
                            == jobLevel.JobLevelName.Trim().ToLower());

            if (duplicate)
                return Conflict("Job Level already exists.");

            existing.JobLevelName = jobLevel.JobLevelName;
            existing.IsActive = jobLevel.IsActive;

            var result = await _service.UpdateJobLevel(existing);

            return Ok(result);
        }

        [HttpDelete("job-level/{id}")]
        public async Task<IActionResult> DeleteJobLevel(int id)
        {
            var existing = await _service.GetJobLevelById(id);

            if (existing == null)
                return NotFound("Job Level not found.");

            await _service.DeleteJobLevel(id);

            return Ok("Job Level deleted successfully.");
        }


        // ==================== EMPLOYMENT TYPE ====================

        [HttpGet("employment-types")]
        public async Task<IActionResult> GetEmploymentTypes()
        {
            return Ok(await _service.GetEmploymentTypes());
        }

        [HttpGet("employment-type/{id}")]
        public async Task<IActionResult> GetEmploymentTypeById(int id)
        {
            var employmentType = await _service.GetEmploymentTypeById(id);

            if (employmentType == null)
                return NotFound("Employment Type not found.");

            return Ok(employmentType);
        }

        [HttpPost("employment-type")]
        public async Task<IActionResult> AddEmploymentType(EmploymentType employmentType)
        {
            var exists = (await _service.GetEmploymentTypes())
                .Any(x => x.EmploymentTypeName.Trim().ToLower()
                            == employmentType.EmploymentTypeName.Trim().ToLower());

            if (exists)
                return Conflict("Employment Type already exists.");

            var result = await _service.AddEmploymentType(employmentType);

            return Ok(result);
        }

        [HttpPut("employment-type/{id}")]
        public async Task<IActionResult> UpdateEmploymentType(int id, EmploymentType employmentType)
        {
            var existing = await _service.GetEmploymentTypeById(id);

            if (existing == null)
                return NotFound("Employment Type not found.");

            var duplicate = (await _service.GetEmploymentTypes())
                .Any(x => x.EmploymentTypeId != id &&
                         x.EmploymentTypeName.Trim().ToLower()
                            == employmentType.EmploymentTypeName.Trim().ToLower());

            if (duplicate)
                return Conflict("Employment Type already exists.");

            existing.EmploymentTypeName = employmentType.EmploymentTypeName;
            existing.IsActive = employmentType.IsActive;

            var result = await _service.UpdateEmploymentType(existing);

            return Ok(result);
        }

        [HttpDelete("employment-type/{id}")]
        public async Task<IActionResult> DeleteEmploymentType(int id)
        {
            var existing = await _service.GetEmploymentTypeById(id);

            if (existing == null)
                return NotFound("Employment Type not found.");

            await _service.DeleteEmploymentType(id);

            return Ok("Employment Type deleted successfully.");
        }


        // ==================== EMPLOYEE CATEGORY ====================

        [HttpGet("employee-categories")]
        public async Task<IActionResult> GetEmployeeCategories()
        {
            return Ok(await _service.GetEmployeeCategories());
        }

        [HttpGet("employee-category/{id}")]
        public async Task<IActionResult> GetEmployeeCategoryById(int id)
        {
            var category = await _service.GetEmployeeCategoryById(id);

            if (category == null)
                return NotFound("Employee Category not found.");

            return Ok(category);
        }

        [HttpPost("employee-category")]
        public async Task<IActionResult> AddEmployeeCategory(EmployeeCategory category)
        {
            var exists = (await _service.GetEmployeeCategories())
                .Any(x => x.EmployeeCategoryName.Trim().ToLower()
                            == category.EmployeeCategoryName.Trim().ToLower());

            if (exists)
                return Conflict("Employee Category already exists.");

            var result = await _service.AddEmployeeCategory(category);

            return Ok(result);
        }

        [HttpPut("employee-category/{id}")]
        public async Task<IActionResult> UpdateEmployeeCategory(int id, EmployeeCategory category)
        {
            var existing = await _service.GetEmployeeCategoryById(id);

            if (existing == null)
                return NotFound("Employee Category not found.");

            var duplicate = (await _service.GetEmployeeCategories())
                .Any(x => x.EmployeeCategoryId != id &&
                         x.EmployeeCategoryName.Trim().ToLower()
                            == category.EmployeeCategoryName.Trim().ToLower());

            if (duplicate)
                return Conflict("Employee Category already exists.");

            existing.EmployeeCategoryName = category.EmployeeCategoryName;
            existing.IsActive = category.IsActive;

            var result = await _service.UpdateEmployeeCategory(existing);

            return Ok(result);
        }

        [HttpDelete("employee-category/{id}")]
        public async Task<IActionResult> DeleteEmployeeCategory(int id)
        {
            var existing = await _service.GetEmployeeCategoryById(id);

            if (existing == null)
                return NotFound("Employee Category not found.");

            await _service.DeleteEmployeeCategory(id);

            return Ok("Employee Category deleted successfully.");
        }


        // ==================== SHIFT ====================

        [HttpGet("shifts")]
        public async Task<IActionResult> GetShifts()
        {
            return Ok(await _service.GetShifts());
        }

        [HttpGet("shift/{id}")]
        public async Task<IActionResult> GetShiftById(int id)
        {
            var shift = await _service.GetShiftById(id);

            if (shift == null)
                return NotFound("Shift not found.");

            return Ok(shift);
        }

        [HttpPost("shift")]
        public async Task<IActionResult> AddShift(Shift shift)
        {
            var exists = (await _service.GetShifts())
                .Any(x => x.ShiftName.Trim().ToLower()
                            == shift.ShiftName.Trim().ToLower());

            if (exists)
                return Conflict("Shift already exists.");

            var result = await _service.AddShift(shift);

            return Ok(result);
        }

        [HttpPut("shift/{id}")]
        public async Task<IActionResult> UpdateShift(int id, Shift shift)
        {
            var existing = await _service.GetShiftById(id);

            if (existing == null)
                return NotFound("Shift not found.");

            var duplicate = (await _service.GetShifts())
                .Any(x => x.ShiftId != id &&
                         x.ShiftName.Trim().ToLower()
                            == shift.ShiftName.Trim().ToLower());

            if (duplicate)
                return Conflict("Shift already exists.");

            existing.ShiftName = shift.ShiftName;
            existing.StartTime = shift.StartTime;
            existing.EndTime = shift.EndTime;
            existing.IsActive = shift.IsActive;

            var result = await _service.UpdateShift(existing);

            return Ok(result);
        }

        [HttpDelete("shift/{id}")]
        public async Task<IActionResult> DeleteShift(int id)
        {
            var existing = await _service.GetShiftById(id);

            if (existing == null)
                return NotFound("Shift not found.");

            await _service.DeleteShift(id);

            return Ok("Shift deleted successfully.");
        }


        // ==================== HOLIDAY ====================

        [HttpGet("holidays")]
        public async Task<IActionResult> GetHolidays()
        {
            return Ok(await _service.GetHolidays());
        }

        [HttpGet("holiday/{id}")]
        public async Task<IActionResult> GetHolidayById(int id)
        {
            var holiday = await _service.GetHolidayById(id);

            if (holiday == null)
                return NotFound("Holiday not found.");

            return Ok(holiday);
        }

        [HttpPost("holiday")]
        public async Task<IActionResult> AddHoliday(Holiday holiday)
        {
            var exists = (await _service.GetHolidays())
                .Any(x => x.HolidayName.Trim().ToLower()
                            == holiday.HolidayName.Trim().ToLower()
                        && x.HolidayDate == holiday.HolidayDate);

            if (exists)
                return Conflict("Holiday already exists for this date.");

            var result = await _service.AddHoliday(holiday);

            return Ok(result);
        }

        [HttpPut("holiday/{id}")]
        public async Task<IActionResult> UpdateHoliday(int id, Holiday holiday)
        {
            var existing = await _service.GetHolidayById(id);

            if (existing == null)
                return NotFound("Holiday not found.");

            var duplicate = (await _service.GetHolidays())
                .Any(x => x.HolidayId != id &&
                          x.HolidayName.Trim().ToLower()
                            == holiday.HolidayName.Trim().ToLower()
                          && x.HolidayDate == holiday.HolidayDate);

            if (duplicate)
                return Conflict("Holiday already exists for this date.");

            existing.HolidayName = holiday.HolidayName;
            existing.HolidayDate = holiday.HolidayDate;

            var result = await _service.UpdateHoliday(existing);

            return Ok(result);
        }

        [HttpDelete("holiday/{id}")]
        public async Task<IActionResult> DeleteHoliday(int id)
        {
            var existing = await _service.GetHolidayById(id);

            if (existing == null)
                return NotFound("Holiday not found.");

            await _service.DeleteHoliday(id);

            return Ok("Holiday deleted successfully.");
        }


        // ==================== LEAVE TYPE ====================

        [HttpGet("leave-types")]
        public async Task<IActionResult> GetLeaveTypes()
        {
            return Ok(await _service.GetLeaveTypes());
        }

        [HttpGet("leave-type/{id}")]
        public async Task<IActionResult> GetLeaveTypeById(int id)
        {
            var leaveType = await _service.GetLeaveTypeById(id);

            if (leaveType == null)
                return NotFound("Leave Type not found.");

            return Ok(leaveType);
        }

        [HttpPost("leave-type")]
        public async Task<IActionResult> AddLeaveType(LeaveType leaveType)
        {
            var exists = (await _service.GetLeaveTypes())
                .Any(x => x.LeaveTypeName.Trim().ToLower()
                            == leaveType.LeaveTypeName.Trim().ToLower());

            if (exists)
                return Conflict("Leave Type already exists.");

            var result = await _service.AddLeaveType(leaveType);

            return Ok(result);
        }

        [HttpPut("leave-type/{id}")]
        public async Task<IActionResult> UpdateLeaveType(int id, LeaveType leaveType)
        {
            var existing = await _service.GetLeaveTypeById(id);

            if (existing == null)
                return NotFound("Leave Type not found.");

            var duplicate = (await _service.GetLeaveTypes())
                .Any(x => x.LeaveTypeId != id &&
                         x.LeaveTypeName.Trim().ToLower()
                            == leaveType.LeaveTypeName.Trim().ToLower());

            if (duplicate)
                return Conflict("Leave Type already exists.");

            existing.LeaveTypeName = leaveType.LeaveTypeName;

            var result = await _service.UpdateLeaveType(existing);

            return Ok(result);
        }

        [HttpDelete("leave-type/{id}")]
        public async Task<IActionResult> DeleteLeaveType(int id)
        {
            var existing = await _service.GetLeaveTypeById(id);

            if (existing == null)
                return NotFound("Leave Type not found.");

            await _service.DeleteLeaveType(id);

            return Ok("Leave Type deleted successfully.");
        }


        // ==================== LEAVE POLICY ====================

        [HttpGet("leave-policies")]
        public async Task<IActionResult> GetLeavePolicies()
        {
            return Ok(await _service.GetLeavePolicies());
        }

        [HttpGet("leave-policy/{id}")]
        public async Task<IActionResult> GetLeavePolicyById(int id)
        {
            var policy = await _service.GetLeavePolicyById(id);

            if (policy == null)
                return NotFound("Leave Policy not found.");

            return Ok(policy);
        }

        [HttpPost("leave-policy")]
        public async Task<IActionResult> AddLeavePolicy(LeavePolicy policy)
        {
            var exists = (await _service.GetLeavePolicies())
                .Any(x => x.LeavePolicyName.Trim().ToLower()
                            == policy.LeavePolicyName.Trim().ToLower());

            if (exists)
                return Conflict("Leave Policy already exists.");

            var result = await _service.AddLeavePolicy(policy);

            return Ok(result);
        }

        [HttpPut("leave-policy/{id}")]
        public async Task<IActionResult> UpdateLeavePolicy(int id, LeavePolicy policy)
        {
            var existing = await _service.GetLeavePolicyById(id);

            if (existing == null)
                return NotFound("Leave Policy not found.");

            var duplicate = (await _service.GetLeavePolicies())
                .Any(x => x.LeavePolicyId != id &&
                         x.LeavePolicyName.Trim().ToLower()
                            == policy.LeavePolicyName.Trim().ToLower());

            if (duplicate)
                return Conflict("Leave Policy already exists.");

            existing.LeavePolicyName = policy.LeavePolicyName;
            existing.LeaveTypeId = policy.LeaveTypeId;
            existing.TotalDays = policy.TotalDays;
            existing.IsActive = policy.IsActive;

            var result = await _service.UpdateLeavePolicy(existing);

            return Ok(result);
        }

        [HttpDelete("leave-policy/{id}")]
        public async Task<IActionResult> DeleteLeavePolicy(int id)
        {
            var existing = await _service.GetLeavePolicyById(id);

            if (existing == null)
                return NotFound("Leave Policy not found.");

            await _service.DeleteLeavePolicy(id);

            return Ok("Leave Policy deleted successfully.");
        }
    }
}