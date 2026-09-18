using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class DeductionTypeService : IDeductionTypeRepository
    {
        private readonly HrmsDbContext _db;

        public DeductionTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<DeductionType>> GetDeductionTypes()
        {
            return await _db.DeductionTypetbl
                .ToListAsync();
        }

        public async Task<DeductionType?> GetDeductionTypeById(int deductionTypeId)
        {
            return await _db.DeductionTypetbl
                .FirstOrDefaultAsync(x =>
                    x.DeductionTypeId == deductionTypeId);
        }

        public async Task<DeductionType> AddDeductionType(DeductionType deductionType)
        {
            deductionType.IsActive = true;

            _db.DeductionTypetbl.Add(deductionType);

            await _db.SaveChangesAsync();

            return deductionType;
        }

        public async Task<DeductionType?> UpdateDeductionType(DeductionType deductionType)
        {
            var existingDeductionType =
                await _db.DeductionTypetbl
                .FirstOrDefaultAsync(x =>
                    x.DeductionTypeId == deductionType.DeductionTypeId);

            if (existingDeductionType == null)
                return null;

            existingDeductionType.DeductionName = deductionType.DeductionName;
            
            existingDeductionType.IsActive = deductionType.IsActive;

            await _db.SaveChangesAsync();

            return existingDeductionType;
        }

        public async Task<bool> DeleteDeductionType(int deductionTypeId)
        {
            var deductionType =
                await _db.DeductionTypetbl
                .FirstOrDefaultAsync(x =>
                    x.DeductionTypeId == deductionTypeId);

            if (deductionType == null)
                return false;

            deductionType.IsActive = false;

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
