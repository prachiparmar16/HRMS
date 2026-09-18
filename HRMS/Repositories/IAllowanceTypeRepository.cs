using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IAllowanceTypeRepository
    {
        Task<List<AllowanceType>> GetAllowanceTypes();

        Task<AllowanceType?> GetAllowanceTypeById(int allowanceTypeId);

        Task<AllowanceType> AddAllowanceType(AllowanceType allowanceType);

        Task<AllowanceType?> UpdateAllowanceType(AllowanceType allowanceType);

        Task<bool> DeleteAllowanceType(int allowanceTypeId);


    }

}
