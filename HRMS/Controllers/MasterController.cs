using HRMS.Models.DTOs;
using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentService;
        private readonly IEmployeeRepository _employeeService;
        private readonly ILeaveRepository _leaveService;

        public MasterController(
            IDepartmentRepository departmentService,
            IEmployeeRepository employeeService,
            ILeaveRepository leaveService)
        {
            _departmentService = departmentService;
            _employeeService = employeeService;
            _leaveService = leaveService;
        }

        // =========================
        // DEPARTMENT
        // =========================

        [HttpGet("GetDepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            var result = await _departmentService.GetDepartments();

            return Ok(result);
        }

        [HttpGet("GetDepartmentById/{departmentId}")]
        public async Task<IActionResult> GetDepartment(
            [FromRoute] int departmentId)
        {
            var result =
                await _departmentService.GetDepartmentById(departmentId);

            if (result == null)
                return NotFound("Department not found.");

            return Ok(result);
        }

        [HttpPost("AddDepartment")]
        public async Task<IActionResult> AddDepartment(
            DepartmentRequest request)
        {
            var department = new EmployeeDepartment
            {
                DepartmentName = request.DepartmentName
            };

            var result =
                await _departmentService.AddDepartment(department);

            return Ok(result);
        }

        [HttpPut("UpdateDepartment")]
        public async Task<IActionResult> UpdateDepartment(
            EmployeeDepartment department)
        {
            var result =
                await _departmentService.UpdateDepartment(department);

            if (result == null)
                return NotFound("Department not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteDepartment")]
        public async Task<IActionResult> DeleteDepartment(
            [FromRoute] int departmentId)
        {
            var result =
                await _departmentService.DeleteDepartment(departmentId);

            if (!result)
                return NotFound("Department not found.");

            return Ok("Department deleted successfully.");
        }


        // =========================
        // EMPLOYEE
        // =========================

        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            var result = await _employeeService.GetEmployees();

            return Ok(result);
        }

        [HttpGet("GetEmployee/{employeeId}")]
        public async Task<IActionResult> GetEmployee(
            [FromRoute] int employeeId)
        {
            var result =
                await _employeeService.GetEmployeeById(employeeId);

            if (result == null)
                return NotFound("Employee not found.");

            return Ok(result);
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(
            Employee employee)
        {
            var result =
                await _employeeService.AddEmployee(employee);

            return Ok(result);
        }

        [HttpPut("UpdateEmployee")]
        public async Task<IActionResult> UpdateEmployee(
            Employee employee)
        {
            var result =
                await _employeeService.UpdateEmployee(employee);

            if (result == null)
                return NotFound("Employee not found.");

            return Ok(result);
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteEmployee(
            [FromRoute] int employeeId)
        {
            var result =
                await _employeeService.DeleteEmployee(employeeId);

            if (!result)
                return NotFound("Employee not found.");

            return Ok("Employee deactivated successfully.");
        }


        // =========================
        // LEAVE
        // =========================

        [HttpPost("RequestLeave")]
        public async Task<IActionResult> RequestLeave(
            LeaveRequest request)
        {
            var leave = new Leave
            {
                EmployeeId = request.EmployeeId,
                LeaveType = request.LeaveType,
                FromDate = request.FromDate,
                ToDate = request.ToDate,
                Reason = request.Reason
            };

            var result =
                await _leaveService.RequestLeave(leave);

            return Ok(result);
        }

        [HttpGet("AllLeaveRequests")]
        public async Task<IActionResult> AllLeaveRequests()
        {
            var result =
                await _leaveService.GetAllLeaveRequests();

            return Ok(result);
        }

        [HttpGet("EmployeeLeaveRequests")]
        public async Task<IActionResult> EmployeeLeaveRequests(
            [FromRoute] int employeeId)
        {
            var result =
                await _leaveService
                .GetEmployeeLeaveRequests(employeeId);

            return Ok(result);
        }

        [HttpGet("GetLeave/{leaveId}")]
        public async Task<IActionResult> GetLeave(
            [FromRoute] int leaveId)
        {
            var result =
                await _leaveService.GetLeaveById(leaveId);

            if (result == null)
                return NotFound("Leave request not found.");

            return Ok(result);
        }

        [HttpPut("WithdrawLeaveRequest/{leaveId}/{employeeId}")]
        public async Task<IActionResult> WithdrawLeaveRequest(
            [FromRoute] int leaveId,
            [FromRoute] int employeeId)
        {
            var result =
                await _leaveService
                .WithdrawLeaveRequest(leaveId, employeeId);

            if (!result)
                return NotFound("Leave request not found.");

            return Ok("Leave request withdrawn successfully.");
        }

        [HttpPut("UpdateLeaveStatus/{leaveId}")]
        public async Task<IActionResult> UpdateLeaveStatus(
            [FromRoute] int leaveId,
            [FromQuery] string status)
        {
            var result =
                await _leaveService
                .UpdateLeaveStatus(leaveId, status);

            if (!result)
                return NotFound("Leave request not found.");

            return Ok("Leave status updated successfully.");
        }
    }
}