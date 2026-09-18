using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class AssetStatusService : IAssetStatusRepository
    {
        private readonly HrmsDbContext _db;

        public AssetStatusService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<AssetStatus>> GetAssetStatuses()
        {
            return await _db.AssetStatustbl
                .ToListAsync();
        }

        public async Task<AssetStatus?> GetAssetStatusById(int assetStatusId)
        {
            return await _db.AssetStatustbl
                .FirstOrDefaultAsync(x =>
                    x.AssetStatusId == assetStatusId);
        }

        public async Task<AssetStatus> AddAssetStatus(
            AssetStatus assetStatus)
        {
            _db.AssetStatustbl.Add(assetStatus);

            await _db.SaveChangesAsync();

            return assetStatus;
        }

        public async Task<AssetStatus?> UpdateAssetStatus(
            AssetStatus assetStatus)
        {
            var existingAssetStatus =
                await _db.AssetStatustbl
                .FirstOrDefaultAsync(x =>
                    x.AssetStatusId ==
                    assetStatus.AssetStatusId);

            if (existingAssetStatus == null)
                return null;

            existingAssetStatus.StatusName =
                assetStatus.StatusName;

            existingAssetStatus.IsActive =
                assetStatus.IsActive;

            await _db.SaveChangesAsync();

            return existingAssetStatus;
        }

        public async Task<bool> DeleteAssetStatus(int assetStatusId)
        {
            var assetStatus =
                await _db.AssetStatustbl
                .FirstOrDefaultAsync(x =>
                    x.AssetStatusId == assetStatusId);

            if (assetStatus == null)
                return false;

            _db.AssetStatustbl.Remove(assetStatus);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
