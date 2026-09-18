using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class PayrollPolicyService : IPayrollPolicyRepository
    {
        private readonly HrmsDbContext _db;

        public PayrollPolicyService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<PayrollPolicy>> GetPayrollPolicies()
        {
            return await _db.PayrollPolicytbl
                .ToListAsync();
        }

        public async Task<PayrollPolicy?> GetPayrollPolicyById(
            int payrollPolicyId)
        {
            return await _db.PayrollPolicytbl
                .FirstOrDefaultAsync(x =>
                    x.PayrollPolicyId == payrollPolicyId);
        }

        public async Task<PayrollPolicy> AddPayrollPolicy(
            PayrollPolicy payrollPolicy)
        {
            payrollPolicy.IsActive = true;

            _db.PayrollPolicytbl.Add(payrollPolicy);

            await _db.SaveChangesAsync();

            return payrollPolicy;
        }

        public async Task<PayrollPolicy?> UpdatePayrollPolicy(
            PayrollPolicy payrollPolicy)
        {
            var existingPayrollPolicy =
                await _db.PayrollPolicytbl
                .FirstOrDefaultAsync(x =>
                    x.PayrollPolicyId ==
                    payrollPolicy.PayrollPolicyId);

            if (existingPayrollPolicy == null)
                return null;

            existingPayrollPolicy.PolicyName =
                payrollPolicy.PolicyName;

            existingPayrollPolicy.Description =
                payrollPolicy.Description;

            existingPayrollPolicy.IsActive =
                payrollPolicy.IsActive;

            await _db.SaveChangesAsync();

            return existingPayrollPolicy;
        }

        public async Task<bool> DeletePayrollPolicy(
            int payrollPolicyId)
        {
            var payrollPolicy =
                await _db.PayrollPolicytbl
                .FirstOrDefaultAsync(x =>
                    x.PayrollPolicyId == payrollPolicyId);

            if (payrollPolicy == null)
                return false;

            payrollPolicy.IsActive = false;

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
