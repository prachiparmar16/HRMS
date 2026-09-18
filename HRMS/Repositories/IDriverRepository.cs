using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IDriverRepository
    {
        Task<List<Driver>> GetDrivers();
        Task<Driver?> GetDriverById(int driverId);
        Task<Driver> AddDriver(Driver driver);
        Task<Driver?> UpdateDriver(Driver driver);
        Task<bool> DeleteDriver(int driverId);
    }
}
