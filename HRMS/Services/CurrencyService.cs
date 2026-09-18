using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class CurrencyService : ICurrencyRepository
    {
        private readonly HrmsDbContext _db;

        public CurrencyService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<Currency>> GetCurrencies()
            => await _db.Currencytbl.ToListAsync();

        public async Task<Currency?> GetCurrencyById(int currencyId)
            => await _db.Currencytbl
                .FirstOrDefaultAsync(x => x.CurrencyId == currencyId);

        public async Task<Currency> AddCurrency(Currency currency)
        {
            _db.Currencytbl.Add(currency);
            await _db.SaveChangesAsync();
            return currency;
        }

        public async Task<Currency?> UpdateCurrency(Currency currency)
        {
            var existing = await _db.Currencytbl
                .FirstOrDefaultAsync(x => x.CurrencyId == currency.CurrencyId);

            if (existing == null)
                return null;

            existing.CurrencyName = currency.CurrencyName;
            existing.CurrencyCode = currency.CurrencyCode;
            existing.IsActive = currency.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteCurrency(int currencyId)
        {
            var currency = await _db.Currencytbl
                .FirstOrDefaultAsync(x => x.CurrencyId == currencyId);

            if (currency == null)
                return false;

            _db.Currencytbl.Remove(currency);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
