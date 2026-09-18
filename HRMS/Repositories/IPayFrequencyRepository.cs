using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IPayFrequencyRepository
    {
        Task<List<PayFrequency>> GetPayFrequencies();

        Task<PayFrequency?> GetPayFrequencyById(int payFrequencyId);

        Task<PayFrequency> AddPayFrequency(PayFrequency payFrequency);
        Task<PayFrequency?> UpdatePayFrequency(PayFrequency payFrequency);

        Task<bool> DeletePayFrequency(int payFrequencyId);
    }

}

