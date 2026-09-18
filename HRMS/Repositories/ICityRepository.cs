using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ICityRepository
    {
        Task<List<City>> GetCities();
        Task<City?> GetCityById(int cityId);
        Task<City> AddCity(City city);
        Task<City?> UpdateCity(City city);
        Task<bool> DeleteCity(int cityId);
    }
}
