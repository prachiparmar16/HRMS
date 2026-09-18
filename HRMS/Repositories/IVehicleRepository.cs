using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IVehicleRepository
    {
        Task<List<Vehicle>> GetVehicles();
        Task<Vehicle?> GetVehicleById(int vehicleId);
        Task<Vehicle> AddVehicle(Vehicle vehicle);
        Task<Vehicle?> UpdateVehicle(Vehicle vehicle);
        Task<bool> DeleteVehicle(int vehicleId);
    }
}
