using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class CityService : ICityRepository
    {
        private readonly HrmsDbContext _db;

        public CityService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<City>> GetCities()
            => await _db.Citytbl.ToListAsync();

        public async Task<City?> GetCityById(int cityId)
            => await _db.Citytbl
                .FirstOrDefaultAsync(x => x.CityId == cityId);

        public async Task<City> AddCity(City city)
        {
            _db.Citytbl.Add(city);
            await _db.SaveChangesAsync();
            return city;
        }

        public async Task<City?> UpdateCity(City city)
        {
            var existing = await _db.Citytbl
                .FirstOrDefaultAsync(x => x.CityId == city.CityId);

            if (existing == null)
                return null;

            existing.CityName = city.CityName;
            existing.StateId = city.StateId;
            existing.IsActive = city.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteCity(int cityId)
        {
            var city = await _db.Citytbl
                .FirstOrDefaultAsync(x => x.CityId == cityId);

            if (city == null)
                return false;

            _db.Citytbl.Remove(city);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
