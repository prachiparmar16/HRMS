using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class PickupPointService : IPickupPointRepository
    {
        private readonly HrmsDbContext _db;

        public PickupPointService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<PickupPoint>> GetPickupPoints()
        {
            return await _db.PickupPointtbl.ToListAsync();
        }

        public async Task<PickupPoint?> GetPickupPointById(int pickupPointId)
        {
            return await _db.PickupPointtbl
                .FirstOrDefaultAsync(x => x.PickupPointId == pickupPointId);
        }

        public async Task<PickupPoint> AddPickupPoint(PickupPoint pickupPoint)
        {
            _db.PickupPointtbl.Add(pickupPoint);
            await _db.SaveChangesAsync();
            return pickupPoint;
        }

        public async Task<PickupPoint?> UpdatePickupPoint(PickupPoint pickupPoint)
        {
            var existing = await _db.PickupPointtbl
                .FirstOrDefaultAsync(x => x.PickupPointId == pickupPoint.PickupPointId);

            if (existing == null)
                return null;

            existing.PickupPointName = pickupPoint.PickupPointName;
            existing.RouteId = pickupPoint.RouteId;
            existing.IsActive = pickupPoint.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeletePickupPoint(int pickupPointId)
        {
            var pickupPoint = await _db.PickupPointtbl
                .FirstOrDefaultAsync(x => x.PickupPointId == pickupPointId);

            if (pickupPoint == null)
                return false;

            _db.PickupPointtbl.Remove(pickupPoint);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
