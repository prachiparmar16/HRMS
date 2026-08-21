using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ILeaveRepository
    {
        Task<Leave> RequestLeave(Leave leave);

        Task<List<Leave>> GetAllLeaveRequests();

        Task<List<Leave>> GetEmployeeLeaveRequests(int employeeId);

        Task<Leave?> GetLeaveById(int leaveId);

        Task<bool> WithdrawLeaveRequest(int leaveId, int employeeId);

        Task<bool> UpdateLeaveStatus(int leaveId, string status);
    }
}