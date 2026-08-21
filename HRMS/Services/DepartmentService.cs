using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class DepartmentService : IDepartmentRepository
    {
        private readonly HrmsDbContext _db;

        public DepartmentService(HrmsDbContext db)
        {
            _db = db;
        }

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
    }
}