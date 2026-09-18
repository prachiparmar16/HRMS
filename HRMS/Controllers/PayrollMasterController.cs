using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    using HRMS.Models.ModelClasses;
    using HRMS.WebAPI.Repositories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class PayrollMasterController : ControllerBase
    {
        private readonly ISalaryComponentRepository _salaryComponent;
        private readonly IAllowanceTypeRepository _allowanceType;
        private readonly IDeductionTypeRepository _deductionType;
        private readonly IPayFrequencyRepository _payFrequency;
        private readonly ISalaryGradeRepository _salaryGrade;
        private readonly ITaxSlabRepository _taxSlab;
        private readonly IPayrollPolicyRepository _payrollPolicy;

        public PayrollMasterController(
            ISalaryComponentRepository salaryComponent,
            IAllowanceTypeRepository allowanceType,
            IDeductionTypeRepository deductionType,
            IPayFrequencyRepository payFrequency,
            ISalaryGradeRepository salaryGrade,
            ITaxSlabRepository taxSlab,
            IPayrollPolicyRepository payrollPolicy)
        {
            _salaryComponent = salaryComponent;
            _allowanceType = allowanceType;
            _deductionType = deductionType;
            _payFrequency = payFrequency;
            _salaryGrade = salaryGrade;
            _taxSlab = taxSlab;
            _payrollPolicy = payrollPolicy;
        }

        // ================= SALARY COMPONENT =================

        [HttpGet("salary-components")]
        public async Task<IActionResult> GetSalaryComponents()
            => Ok(await _salaryComponent.GetSalaryComponents());

        [HttpPost("salary-components")]
        public async Task<IActionResult> AddSalaryComponent(
            SalaryComponent salaryComponent)
            => Ok(await _salaryComponent.AddSalaryComponent(salaryComponent));

        [HttpPut("salary-components")]
        public async Task<IActionResult> UpdateSalaryComponent(
            SalaryComponent salaryComponent)
        {
            var result =
                await _salaryComponent.UpdateSalaryComponent(salaryComponent);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("salary-components/{id}")]
        public async Task<IActionResult> DeleteSalaryComponent(int id)
        {
            var result =
                await _salaryComponent.DeleteSalaryComponent(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= ALLOWANCE TYPE =================

        [HttpGet("allowance-types")]
        public async Task<IActionResult> GetAllowanceTypes()
            => Ok(await _allowanceType.GetAllowanceTypes());

        [HttpPost("allowance-types")]
        public async Task<IActionResult> AddAllowanceType(
            AllowanceType allowanceType)
            => Ok(await _allowanceType.AddAllowanceType(allowanceType));

        [HttpPut("allowance-types")]
        public async Task<IActionResult> UpdateAllowanceType(
            AllowanceType allowanceType)
        {
            var result =
                await _allowanceType.UpdateAllowanceType(allowanceType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("allowance-types/{id}")]
        public async Task<IActionResult> DeleteAllowanceType(int id)
        {
            var result =
                await _allowanceType.DeleteAllowanceType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= DEDUCTION TYPE =================

        [HttpGet("deduction-types")]
        public async Task<IActionResult> GetDeductionTypes()
            => Ok(await _deductionType.GetDeductionTypes());

        [HttpPost("deduction-types")]
        public async Task<IActionResult> AddDeductionType(
            DeductionType deductionType)
            => Ok(await _deductionType.AddDeductionType(deductionType));

        [HttpPut("deduction-types")]
        public async Task<IActionResult> UpdateDeductionType(
            DeductionType deductionType)
        {
            var result =
                await _deductionType.UpdateDeductionType(deductionType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("deduction-types/{id}")]
        public async Task<IActionResult> DeleteDeductionType(int id)
        {
            var result =
                await _deductionType.DeleteDeductionType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= PAY FREQUENCY =================

        [HttpGet("pay-frequencies")]
        public async Task<IActionResult> GetPayFrequencies()
            => Ok(await _payFrequency.GetPayFrequencies());

        [HttpPost("pay-frequencies")]
        public async Task<IActionResult> AddPayFrequency(
            PayFrequency payFrequency)
            => Ok(await _payFrequency.AddPayFrequency(payFrequency));

        [HttpPut("pay-frequencies")]
        public async Task<IActionResult> UpdatePayFrequency(
            PayFrequency payFrequency)
        {
            var result =
                await _payFrequency.UpdatePayFrequency(payFrequency);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("pay-frequencies/{id}")]
        public async Task<IActionResult> DeletePayFrequency(int id)
        {
            var result =
                await _payFrequency.DeletePayFrequency(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= SALARY GRADE =================

        [HttpGet("salary-grades")]
        public async Task<IActionResult> GetSalaryGrades()
            => Ok(await _salaryGrade.GetSalaryGrades());

        [HttpPost("salary-grades")]
        public async Task<IActionResult> AddSalaryGrade(
            SalaryGrade salaryGrade)
            => Ok(await _salaryGrade.AddSalaryGrade(salaryGrade));

        [HttpPut("salary-grades")]
        public async Task<IActionResult> UpdateSalaryGrade(
            SalaryGrade salaryGrade)
        {
            var result =
                await _salaryGrade.UpdateSalaryGrade(salaryGrade);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("salary-grades/{id}")]
        public async Task<IActionResult> DeleteSalaryGrade(int id)
        {
            var result =
                await _salaryGrade.DeleteSalaryGrade(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= TAX SLAB =================

        [HttpGet("tax-slabs")]
        public async Task<IActionResult> GetTaxSlabs()
            => Ok(await _taxSlab.GetTaxSlabs());

        [HttpPost("tax-slabs")]
        public async Task<IActionResult> AddTaxSlab(
            TaxSlab taxSlab)
            => Ok(await _taxSlab.AddTaxSlab(taxSlab));

        [HttpPut("tax-slabs")]
        public async Task<IActionResult> UpdateTaxSlab(
            TaxSlab taxSlab)
        {
            var result =
                await _taxSlab.UpdateTaxSlab(taxSlab);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("tax-slabs/{id}")]
        public async Task<IActionResult> DeleteTaxSlab(int id)
        {
            var result =
                await _taxSlab.DeleteTaxSlab(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= PAYROLL POLICY =================

        [HttpGet("payroll-policies")]
        public async Task<IActionResult> GetPayrollPolicies()
            => Ok(await _payrollPolicy.GetPayrollPolicies());

        [HttpPost("payroll-policies")]
        public async Task<IActionResult> AddPayrollPolicy(
            PayrollPolicy payrollPolicy)
            => Ok(await _payrollPolicy.AddPayrollPolicy(payrollPolicy));

        [HttpPut("payroll-policies")]
        public async Task<IActionResult> UpdatePayrollPolicy(
            PayrollPolicy payrollPolicy)
        {
            var result =
                await _payrollPolicy.UpdatePayrollPolicy(payrollPolicy);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("payroll-policies/{id}")]
        public async Task<IActionResult> DeletePayrollPolicy(int id)
        {
            var result =
                await _payrollPolicy.DeletePayrollPolicy(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }
    }
}
