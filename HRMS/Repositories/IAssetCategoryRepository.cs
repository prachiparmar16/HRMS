using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IAssetCategoryRepository
    {
        Task<List<AssetCategory>> GetAssetCategories();
        Task<AssetCategory?> GetAssetCategoryById(int assetCategoryId);
        Task<AssetCategory> AddAssetCategory(AssetCategory assetCategory);
        Task<AssetCategory?> UpdateAssetCategory(AssetCategory assetCategory);
        Task<bool> DeleteAssetCategory(int assetCategoryId);
    }
}
