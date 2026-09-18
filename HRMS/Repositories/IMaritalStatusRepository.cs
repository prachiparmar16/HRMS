using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IMaritalStatusRepository
    {
        Task<List<MaritalStatus>> GetMaritalStatuses();
        Task<MaritalStatus?> GetMaritalStatusById(int maritalStatusId);
        Task<MaritalStatus> AddMaritalStatus(MaritalStatus maritalStatus);
        Task<MaritalStatus?> UpdateMaritalStatus(MaritalStatus maritalStatus);
        Task<bool> DeleteMaritalStatus(int maritalStatusId);
    }
}
