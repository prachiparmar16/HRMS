using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IAssetStatusRepository
    {
        Task<List<AssetStatus>> GetAssetStatuses();
        Task<AssetStatus?> GetAssetStatusById(int assetStatusId);
        Task<AssetStatus> AddAssetStatus(AssetStatus assetStatus);
        Task<AssetStatus?> UpdateAssetStatus(AssetStatus assetStatus);
        Task<bool> DeleteAssetStatus(int assetStatusId);
    }
}

