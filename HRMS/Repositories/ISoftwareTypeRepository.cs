using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ISoftwareTypeRepository
    {
        Task<List<SoftwareType>> GetSoftwareTypes();
        Task<SoftwareType?> GetSoftwareTypeById(int softwareTypeId);
        Task<SoftwareType> AddSoftwareType(SoftwareType softwareType);
        Task<SoftwareType?> UpdateSoftwareType(SoftwareType softwareType);
        Task<bool> DeleteSoftwareType(int softwareTypeId);
    }
}
