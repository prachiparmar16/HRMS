using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly HrmsDbContext _db;

        public EmployeeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _db.Employeestbl
                .ToListAsync();
        }

        public async Task<Employee?> GetEmployeeById(int employeeId)
        {
            return await _db.Employeestbl
                .FirstOrDefaultAsync(x =>
                    x.EmployeeId == employeeId);
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.IsActive = true;

            _db.Employeestbl.Add(employee);

            await _db.SaveChangesAsync();

            return employee;
        }

        public async Task<Employee?> UpdateEmployee(Employee employee)
        {
            var existingEmployee =
                await _db.Employeestbl
                .FirstOrDefaultAsync(x =>
                    x.EmployeeId == employee.EmployeeId);

            if (existingEmployee == null)
                return null;

            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.MiddleName = employee.MiddleName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Gender = employee.Gender;
            existingEmployee.DateOfBirth = employee.DateOfBirth;
            existingEmployee.PersonalEmail = employee.PersonalEmail;
            existingEmployee.Contact = employee.Contact;
            existingEmployee.CompanyEmail = employee.CompanyEmail;
            existingEmployee.DepartmentId = employee.DepartmentId;
            existingEmployee.DesignationId = employee.DesignationId;
            existingEmployee.GradeId = employee.GradeId;
            existingEmployee.DateOfJoining = employee.DateOfJoining;
            existingEmployee.EmploymentType = employee.EmploymentType;
            existingEmployee.EmployeeStatus = employee.EmployeeStatus;
            existingEmployee.IsActive = employee.IsActive;

            await _db.SaveChangesAsync();

            return existingEmployee;
        }

        public async Task<bool> DeleteEmployee(int employeeId)
        {
            var employee =
                await _db.Employeestbl
                .FirstOrDefaultAsync(x =>
                    x.EmployeeId == employeeId);

            if (employee == null)
                return false;

            employee.IsActive = false;
            employee.EmployeeStatus = "Inactive";

            await _db.SaveChangesAsync();

            return true;
        }
    }
}