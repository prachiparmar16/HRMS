using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class AssetCategoryService : IAssetCategoryRepository
    {
        private readonly HrmsDbContext _db;

        public AssetCategoryService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<AssetCategory>> GetAssetCategories()
        {
            return await _db.AssetCategorytbl
                .ToListAsync();
        }

        public async Task<AssetCategory?> GetAssetCategoryById(int assetCategoryId)
        {
            return await _db.AssetCategorytbl
                .FirstOrDefaultAsync(x =>
                    x.AssetCategoryId == assetCategoryId);
        }

        public async Task<AssetCategory> AddAssetCategory(
            AssetCategory assetCategory)
        {
            _db.AssetCategorytbl.Add(assetCategory);

            await _db.SaveChangesAsync();

            return assetCategory;
        }

        public async Task<AssetCategory?> UpdateAssetCategory(
            AssetCategory assetCategory)
        {
            var existingAssetCategory =
                await _db.AssetCategorytbl
                .FirstOrDefaultAsync(x =>
                    x.AssetCategoryId ==
                    assetCategory.AssetCategoryId);

            if (existingAssetCategory == null)
                return null;

            existingAssetCategory.CategoryName =
                assetCategory.CategoryName;

            existingAssetCategory.IsActive =
                assetCategory.IsActive;

            await _db.SaveChangesAsync();

            return existingAssetCategory;
        }

        public async Task<bool> DeleteAssetCategory(int assetCategoryId)
        {
            var assetCategory =
                await _db.AssetCategorytbl
                .FirstOrDefaultAsync(x =>
                    x.AssetCategoryId == assetCategoryId);

            if (assetCategory == null)
                return false;

            _db.AssetCategorytbl.Remove(assetCategory);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
