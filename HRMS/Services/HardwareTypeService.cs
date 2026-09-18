using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{

    public class HardwareTypeService : IHardwareTypeRepository
    {
        private readonly HrmsDbContext _db;

        public HardwareTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<HardwareType>> GetHardwareTypes()
        {
            return await _db.HardwareTypetbl
                .ToListAsync();
        }

        public async Task<HardwareType?> GetHardwareTypeById(int hardwareTypeId)
        {
            return await _db.HardwareTypetbl
                .FirstOrDefaultAsync(x =>
                    x.HardwareTypeId == hardwareTypeId);
        }

        public async Task<HardwareType> AddHardwareType(
            HardwareType hardwareType)
        {
            _db.HardwareTypetbl.Add(hardwareType);

            await _db.SaveChangesAsync();

            return hardwareType;
        }

        public async Task<HardwareType?> UpdateHardwareType(
            HardwareType hardwareType)
        {
            var existingHardwareType =
                await _db.HardwareTypetbl
                .FirstOrDefaultAsync(x =>
                    x.HardwareTypeId ==
                    hardwareType.HardwareTypeId);

            if (existingHardwareType == null)
                return null;

            existingHardwareType.HardwareTypeName =
                hardwareType.HardwareTypeName;

            existingHardwareType.IsActive =
                hardwareType.IsActive;

            await _db.SaveChangesAsync();

            return existingHardwareType;
        }

        public async Task<bool> DeleteHardwareType(int hardwareTypeId)
        {
            var hardwareType =
                await _db.HardwareTypetbl
                .FirstOrDefaultAsync(x =>
                    x.HardwareTypeId == hardwareTypeId);

            if (hardwareType == null)
                return false;

            _db.HardwareTypetbl.Remove(hardwareType);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}

