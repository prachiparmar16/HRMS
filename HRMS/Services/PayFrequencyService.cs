using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class PayFrequencyService : IPayFrequencyRepository
    {
        private readonly HrmsDbContext _db;

        public PayFrequencyService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<PayFrequency>> GetPayFrequencies()
        {
            return await _db.PayFrequencytbl
                .ToListAsync();
        }

        public async Task<PayFrequency?> GetPayFrequencyById(int payFrequencyId)
        {
            return await _db.PayFrequencytbl
                .FirstOrDefaultAsync(x =>
                    x.PayFrequencyId == payFrequencyId);
        }

        public async Task<PayFrequency> AddPayFrequency(PayFrequency payFrequency)
        {
            payFrequency.IsActive = true;

            _db.PayFrequencytbl.Add(payFrequency);

            await _db.SaveChangesAsync();

            return payFrequency;
        }

        public async Task<PayFrequency?> UpdatePayFrequency(PayFrequency payFrequency)
        {
            var existingPayFrequency =
                await _db.PayFrequencytbl
                .FirstOrDefaultAsync(x =>
                    x.PayFrequencyId == payFrequency.PayFrequencyId);

            if (existingPayFrequency == null)
                return null;

            

            existingPayFrequency.IsActive =
                payFrequency.IsActive;

            await _db.SaveChangesAsync();

            return existingPayFrequency;
        }

        public async Task<bool> DeletePayFrequency(int payFrequencyId)
        {
            var payFrequency =
                await _db.PayFrequencytbl
                .FirstOrDefaultAsync(x =>
                    x.PayFrequencyId == payFrequencyId);

            if (payFrequency == null)
                return false;

            payFrequency.IsActive = false;

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
