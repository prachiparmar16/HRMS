using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class VehicleTypeService : IVehicleTypeRepository
    {
        private readonly HrmsDbContext _db;

        public VehicleTypeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<VehicleType>> GetVehicleTypes()
        {
            return await _db.VehicleTypetbl.ToListAsync();
        }

        public async Task<VehicleType?> GetVehicleTypeById(int vehicleTypeId)
        {
            return await _db.VehicleTypetbl
                .FirstOrDefaultAsync(x => x.VehicleTypeId == vehicleTypeId);
        }

        public async Task<VehicleType> AddVehicleType(VehicleType vehicleType)
        {
            _db.VehicleTypetbl.Add(vehicleType);
            await _db.SaveChangesAsync();
            return vehicleType;
        }

        public async Task<VehicleType?> UpdateVehicleType(VehicleType vehicleType)
        {
            var existing = await _db.VehicleTypetbl
                .FirstOrDefaultAsync(x => x.VehicleTypeId == vehicleType.VehicleTypeId);

            if (existing == null)
                return null;

            existing.VehicleTypeName = vehicleType.VehicleTypeName;
            existing.IsActive = vehicleType.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteVehicleType(int vehicleTypeId)
        {
            var vehicleType = await _db.VehicleTypetbl
                .FirstOrDefaultAsync(x => x.VehicleTypeId == vehicleTypeId);

            if (vehicleType == null)
                return false;

            _db.VehicleTypetbl.Remove(vehicleType);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
