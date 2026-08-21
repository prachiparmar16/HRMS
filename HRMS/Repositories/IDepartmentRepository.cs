using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IDepartmentRepository
    {
        Task<List<EmployeeDepartment>> GetDepartments();

        Task<EmployeeDepartment?> GetDepartmentById(int departmentId);

        Task<EmployeeDepartment> AddDepartment(EmployeeDepartment department);

        Task<EmployeeDepartment?> UpdateDepartment(EmployeeDepartment department);

        Task<bool> DeleteDepartment(int departmentId);
    }
}