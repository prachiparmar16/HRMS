using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IHardwareTypeRepository
    {
        Task<List<HardwareType>> GetHardwareTypes();
        Task<HardwareType?> GetHardwareTypeById(int hardwareTypeId);
        Task<HardwareType> AddHardwareType(HardwareType hardwareType);
        Task<HardwareType?> UpdateHardwareType(HardwareType hardwareType);
        Task<bool> DeleteHardwareType(int hardwareTypeId);
    }
}
