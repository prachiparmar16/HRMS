using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IDeductionTypeRepository
    {

        Task<List<DeductionType>> GetDeductionTypes();

        Task<DeductionType?> GetDeductionTypeById(int deductionTypeId);

        Task<DeductionType> AddDeductionType(DeductionType deductionType);
        Task<DeductionType?> UpdateDeductionType(DeductionType deductionType);

        Task<bool> DeleteDeductionType(int deductionTypeId);

    }
}
