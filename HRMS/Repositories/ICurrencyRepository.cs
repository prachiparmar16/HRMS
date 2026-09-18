using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ICurrencyRepository
    {
        Task<List<Currency>> GetCurrencies();
        Task<Currency?> GetCurrencyById(int currencyId);
        Task<Currency> AddCurrency(Currency currency);
        Task<Currency?> UpdateCurrency(Currency currency);
        Task<bool> DeleteCurrency(int currencyId);
    }
}
