using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IAssetBrandRepository
    {
        Task<List<AssetBrand>> GetAssetBrands();
        Task<AssetBrand?> GetAssetBrandById(int assetBrandId);
        Task<AssetBrand> AddAssetBrand(AssetBrand assetBrand);
        Task<AssetBrand?> UpdateAssetBrand(AssetBrand assetBrand);
        Task<bool> DeleteAssetBrand(int assetBrandId);
    }
}
