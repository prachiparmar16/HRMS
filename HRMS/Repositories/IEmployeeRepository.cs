using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployees();

        Task<Employee?> GetEmployeeById(int employeeId);

        Task<Employee> AddEmployee(Employee employee);

        Task<Employee?> UpdateEmployee(Employee employee);

        Task<bool> DeleteEmployee(int employeeId);
    }
}