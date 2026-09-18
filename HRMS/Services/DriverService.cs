using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class DriverService : IDriverRepository
    {
        private readonly HrmsDbContext _db;

        public DriverService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<Driver>> GetDrivers()
        {
            return await _db.Drivertbl.ToListAsync();
        }

        public async Task<Driver?> GetDriverById(int driverId)
        {
            return await _db.Drivertbl
                .FirstOrDefaultAsync(x => x.DriverId == driverId);
        }

        public async Task<Driver> AddDriver(Driver driver)
        {
            _db.Drivertbl.Add(driver);
            await _db.SaveChangesAsync();
            return driver;
        }

        public async Task<Driver?> UpdateDriver(Driver driver)
        {
            var existing = await _db.Drivertbl
                .FirstOrDefaultAsync(x => x.DriverId == driver.DriverId);

            if (existing == null)
                return null;

            existing.DriverName = driver.DriverName;
            existing.ContactNumber = driver.ContactNumber;
            existing.LicenseNumber = driver.LicenseNumber;
            existing.IsActive = driver.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteDriver(int driverId)
        {
            var driver = await _db.Drivertbl
                .FirstOrDefaultAsync(x => x.DriverId == driverId);

            if (driver == null)
                return false;

            _db.Drivertbl.Remove(driver);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
