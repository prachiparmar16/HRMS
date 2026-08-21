using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class LeaveService : ILeaveRepository
    {
        private readonly HrmsDbContext _db;

        public LeaveService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<Leave> RequestLeave(Leave leave)
        {
            leave.AppliedDate =
                DateOnly.FromDateTime(DateTime.Now);

            leave.LeaveDays =
                leave.ToDate.DayNumber -
                leave.FromDate.DayNumber + 1;

            leave.Status = "Pending";

            _db.Leavestbl.Add(leave);

            await _db.SaveChangesAsync();

            return leave;
        }

        public async Task<List<Leave>> GetAllLeaveRequests()
        {
            return await _db.Leavestbl
                .ToListAsync();
        }

        public async Task<List<Leave>> GetEmployeeLeaveRequests(
            int employeeId)
        {
            return await _db.Leavestbl
                .Where(x => x.EmployeeId == employeeId)
                .ToListAsync();
        }

        public async Task<Leave?> GetLeaveById(int leaveId)
        {
            return await _db.Leavestbl
                .FirstOrDefaultAsync(x =>
                    x.LeaveId == leaveId);
        }

        public async Task<bool> WithdrawLeaveRequest(
            int leaveId,
            int employeeId)
        {
            var leave =
                await _db.Leavestbl
                .FirstOrDefaultAsync(x =>
                    x.LeaveId == leaveId &&
                    x.EmployeeId == employeeId);

            if (leave == null)
                return false;

            leave.Status = "Withdrawn";

            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateLeaveStatus(
            int leaveId,
            string status)
        {
            var leave =
                await _db.Leavestbl
                .FirstOrDefaultAsync(x =>
                    x.LeaveId == leaveId);

            if (leave == null)
                return false;

            leave.Status = status;

            await _db.SaveChangesAsync();

            return true;
        }
    }
}