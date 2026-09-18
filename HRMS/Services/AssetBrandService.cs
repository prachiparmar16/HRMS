using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class AssetBrandService : IAssetBrandRepository
    {
        private readonly HrmsDbContext _db;

        public AssetBrandService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<AssetBrand>> GetAssetBrands()
        {
            return await _db.AssetBrandtbl
                .ToListAsync();
        }

        public async Task<AssetBrand?> GetAssetBrandById(int assetBrandId)
        {
            return await _db.AssetBrandtbl
                .FirstOrDefaultAsync(x =>
                    x.AssetBrandId == assetBrandId);
        }

        public async Task<AssetBrand> AddAssetBrand(AssetBrand assetBrand)
        {
            _db.AssetBrandtbl.Add(assetBrand);

            await _db.SaveChangesAsync();

            return assetBrand;
        }

        public async Task<AssetBrand?> UpdateAssetBrand(AssetBrand assetBrand)
        {
            var existingAssetBrand =
                await _db.AssetBrandtbl
                .FirstOrDefaultAsync(x =>
                    x.AssetBrandId == assetBrand.AssetBrandId);

            if (existingAssetBrand == null)
                return null;

            existingAssetBrand.BrandName =
                assetBrand.BrandName;

            existingAssetBrand.IsActive =
                assetBrand.IsActive;

            await _db.SaveChangesAsync();

            return existingAssetBrand;
        }

        public async Task<bool> DeleteAssetBrand(int assetBrandId)
        {
            var assetBrand =
                await _db.AssetBrandtbl
                .FirstOrDefaultAsync(x =>
                    x.AssetBrandId == assetBrandId);

            if (assetBrand == null)
                return false;

            _db.AssetBrandtbl.Remove(assetBrand);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
