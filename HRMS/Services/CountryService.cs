using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;



namespace HRMS.WebAPI.Services
{
    public class CountryService : ICountryRepository
    {
        private readonly HrmsDbContext _db;

        public CountryService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<Country>> GetCountries()
            => await _db.Countrytbl.ToListAsync();

        public async Task<Country?> GetCountryById(int countryId)
            => await _db.Countrytbl
                .FirstOrDefaultAsync(x => x.CountryId == countryId);

        public async Task<Country> AddCountry(Country country)
        {
            _db.Countrytbl.Add(country);
            await _db.SaveChangesAsync();
            return country;
        }

        public async Task<Country?> UpdateCountry(Country country)
        {
            var existing = await _db.Countrytbl
                .FirstOrDefaultAsync(x => x.CountryId == country.CountryId);

            if (existing == null)
                return null;

            existing.CountryName = country.CountryName;
            existing.IsActive = country.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteCountry(int countryId)
        {
            var country = await _db.Countrytbl
                .FirstOrDefaultAsync(x => x.CountryId == countryId);

            if (country == null)
                return false;

            _db.Countrytbl.Remove(country);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
