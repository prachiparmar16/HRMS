using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class SoftwareTypeService : ISoftwareTypeRepository
    {
        private readonly HrmsDbContext _db;

        public SoftwareTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<SoftwareType>> GetSoftwareTypes()
        {
            return await _db.SoftwareTypetbl
                .ToListAsync();
        }

        public async Task<SoftwareType?> GetSoftwareTypeById(int softwareTypeId)
        {
            return await _db.SoftwareTypetbl
                .FirstOrDefaultAsync(x =>
                    x.SoftwareTypeId == softwareTypeId);
        }

        public async Task<SoftwareType> AddSoftwareType(
            SoftwareType softwareType)
        {
            _db.SoftwareTypetbl.Add(softwareType);

            await _db.SaveChangesAsync();

            return softwareType;
        }

        public async Task<SoftwareType?> UpdateSoftwareType(
            SoftwareType softwareType)
        {
            var existingSoftwareType =
                await _db.SoftwareTypetbl
                .FirstOrDefaultAsync(x =>
                    x.SoftwareTypeId ==
                    softwareType.SoftwareTypeId);

            if (existingSoftwareType == null)
                return null;

            existingSoftwareType.SoftwareTypeName =
                softwareType.SoftwareTypeName;

            existingSoftwareType.IsActive =
                softwareType.IsActive;

            await _db.SaveChangesAsync();

            return existingSoftwareType;
        }

        public async Task<bool> DeleteSoftwareType(int softwareTypeId)
        {
            var softwareType =
                await _db.SoftwareTypetbl
                .FirstOrDefaultAsync(x =>
                    x.SoftwareTypeId == softwareTypeId);

            if (softwareType == null)
                return false;

            _db.SoftwareTypetbl.Remove(softwareType);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}