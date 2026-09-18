using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IPickupPointRepository
    {
        Task<List<PickupPoint>> GetPickupPoints();
        Task<PickupPoint?> GetPickupPointById(int pickupPointId);
        Task<PickupPoint> AddPickupPoint(PickupPoint pickupPoint);
        Task<PickupPoint?> UpdatePickupPoint(PickupPoint pickupPoint);
        Task<bool> DeletePickupPoint(int pickupPointId);
    }
}
