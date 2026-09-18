using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class VehicleService : IVehicleRepository
    {
        private readonly HrmsDbContext _db;

        public VehicleService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            return await _db.Vehicletbl.ToListAsync();
        }

        public async Task<Vehicle?> GetVehicleById(int vehicleId)
        {
            return await _db.Vehicletbl
                .FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
        }

        public async Task<Vehicle> AddVehicle(Vehicle vehicle)
        {
            _db.Vehicletbl.Add(vehicle);
            await _db.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle?> UpdateVehicle(Vehicle vehicle)
        {
            var existing = await _db.Vehicletbl
                .FirstOrDefaultAsync(x => x.VehicleId == vehicle.VehicleId);

            if (existing == null)
                return null;

            existing.VehicleNumber = vehicle.VehicleNumber;
            existing.VehicleName = vehicle.VehicleName;
            existing.VehicleTypeId = vehicle.VehicleTypeId;
            existing.SeatingCapacity = vehicle.SeatingCapacity;
            existing.IsActive = vehicle.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteVehicle(int vehicleId)
        {
            var vehicle = await _db.Vehicletbl
                .FirstOrDefaultAsync(x => x.VehicleId == vehicleId);

            if (vehicle == null)
                return false;

            _db.Vehicletbl.Remove(vehicle);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
