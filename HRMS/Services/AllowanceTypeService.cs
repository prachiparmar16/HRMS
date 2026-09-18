using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class AllowanceTypeService : IAllowanceTypeRepository
    {
        private readonly HrmsDbContext _db;

        public AllowanceTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<AllowanceType>> GetAllowanceTypes()
        {
            return await _db.AllowanceTypetbl
                .ToListAsync();
        }

        public async Task<AllowanceType?> GetAllowanceTypeById(
            int allowanceTypeId)
        {
            return await _db.AllowanceTypetbl
                .FirstOrDefaultAsync(x =>
                    x.AllowanceTypeId == allowanceTypeId);
        }

        public async Task<AllowanceType> AddAllowanceType(
            AllowanceType allowanceType)
        {
            allowanceType.IsActive = true;

            _db.AllowanceTypetbl.Add(allowanceType);

            await _db.SaveChangesAsync();

            return allowanceType;
        }

        public async Task<AllowanceType?> UpdateAllowanceType(
            AllowanceType allowanceType)
        {
            var existingAllowanceType =
                await _db.AllowanceTypetbl
                .FirstOrDefaultAsync(x =>
                    x.AllowanceTypeId ==
                    allowanceType.AllowanceTypeId);

            if (existingAllowanceType == null)
                return null;

            existingAllowanceType.AllowanceName =
                allowanceType.AllowanceName;

            

            existingAllowanceType.IsTaxable =
                allowanceType.IsTaxable;

            existingAllowanceType.IsActive =
                allowanceType.IsActive;

            await _db.SaveChangesAsync();

            return existingAllowanceType;
        }

        public async Task<bool> DeleteAllowanceType(
            int allowanceTypeId)
        {
            var allowanceType =
                await _db.AllowanceTypetbl
                .FirstOrDefaultAsync(x =>
                    x.AllowanceTypeId == allowanceTypeId);

            if (allowanceType == null)
                return false;

            allowanceType.IsActive = false;

            await _db.SaveChangesAsync();

            return true;
        }

    }
}



