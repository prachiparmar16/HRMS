using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IPayrollPolicyRepository
    {
    Task<List<PayrollPolicy>> GetPayrollPolicies();

    Task<PayrollPolicy?> GetPayrollPolicyById(int payrollPolicyId);

    Task<PayrollPolicy> AddPayrollPolicy(PayrollPolicy payrollPolicy);
    Task<PayrollPolicy?> UpdatePayrollPolicy(PayrollPolicy payrollPolicy);

    Task<bool> DeletePayrollPolicy(int payrollPolicyId);

    }
}
