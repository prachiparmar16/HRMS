using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ISalaryComponentRepository
    {
        Task<List<SalaryComponent>> GetSalaryComponents();
        Task<SalaryComponent?> GetSalaryComponentById(int salaryComponentId);

        Task<SalaryComponent> AddSalaryComponent(SalaryComponent salaryComponent);

        Task<SalaryComponent?> UpdateSalaryComponent(SalaryComponent salaryComponent);

        Task<bool> DeleteSalaryComponent(int salaryComponentId);
    }
}
