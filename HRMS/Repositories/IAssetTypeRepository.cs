using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IAssetTypeRepository
    {
        Task<List<AssetType>> GetAssetTypes();

        Task<AssetType?> GetAssetTypeById(int assetTypeId);

        Task<AssetType> AddAssetType(AssetType assetType);

        Task<AssetType?> UpdateAssetType(AssetType assetType);

        Task<bool> DeleteAssetType(int assetTypeId);
    }
}
