using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IBloodGroupRepository
    {
        Task<List<BloodGroup>> GetBloodGroups();
        Task<BloodGroup?> GetBloodGroupById(int bloodGroupId);
        Task<BloodGroup> AddBloodGroup(BloodGroup bloodGroup);
        Task<BloodGroup?> UpdateBloodGroup(BloodGroup bloodGroup);
        Task<bool> DeleteBloodGroup(int bloodGroupId);
    }
}
