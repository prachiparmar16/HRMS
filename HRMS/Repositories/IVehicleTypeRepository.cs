using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IVehicleTypeRepository
    {
        Task<List<VehicleType>> GetVehicleTypes();
        Task<VehicleType?> GetVehicleTypeById(int vehicleTypeId);
        Task<VehicleType> AddVehicleType(VehicleType vehicleType);
        Task<VehicleType?> UpdateVehicleType(VehicleType vehicleType);
        Task<bool> DeleteVehicleType(int vehicleTypeId);
    }
}
