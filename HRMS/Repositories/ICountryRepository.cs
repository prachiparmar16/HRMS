using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetCountries();
        Task<Country?> GetCountryById(int countryId);
        Task<Country> AddCountry(Country country);
        Task<Country?> UpdateCountry(Country country);
        Task<bool> DeleteCountry(int countryId);
    }
}
