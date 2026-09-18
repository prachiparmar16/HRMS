using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using HRMS.Models.ModelClasses;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class AssetTypeService : IAssetTypeRepository
    {
        private readonly HrmsDbContext _db;

        public AssetTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<AssetType>> GetAssetTypes()
        {
            return await _db.AssetTypetbl
                .ToListAsync();
        }

        public async Task<AssetType?> GetAssetTypeById(int assetTypeId)
        {
            return await _db.AssetTypetbl
                .FirstOrDefaultAsync(x =>
                    x.AssetTypeId == assetTypeId);
        }

        public async Task<AssetType> AddAssetType(AssetType assetType)
        {
            _db.AssetTypetbl.Add(assetType);

            await _db.SaveChangesAsync();

            return assetType;
        }

        public async Task<AssetType?> UpdateAssetType(AssetType assetType)
        {
            var existingAssetType =
                await _db.AssetTypetbl
                .FirstOrDefaultAsync(x =>
                    x.AssetTypeId == assetType.AssetTypeId);

            if (existingAssetType == null)
                return null;

            existingAssetType.AssetTypeName =
                assetType.AssetTypeName;

            existingAssetType.IsActive =
                assetType.IsActive;

            await _db.SaveChangesAsync();

            return existingAssetType;
        }

        public async Task<bool> DeleteAssetType(int assetTypeId)
        {
            var assetType =
                await _db.AssetTypetbl
                .FirstOrDefaultAsync(x =>
                    x.AssetTypeId == assetTypeId);

            if (assetType == null)
                return false;

            _db.AssetTypetbl.Remove(assetType);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
