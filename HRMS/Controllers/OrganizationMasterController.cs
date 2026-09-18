using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrganizationMasterController : ControllerBase
    {
        private readonly IOrganizationMasterRepository _service;

        public OrganizationMasterController(IOrganizationMasterRepository service)
        {
            _service = service;
        }

        // ==================== COMPANY ====================

        [HttpGet("companies")]
        public async Task<IActionResult> GetCompanies()
        {
            return Ok(await _service.GetCompanies());
        }

        [HttpGet("company/{id}")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            var company = await _service.GetCompanyById(id);

            if (company == null)
                return NotFound("Company not found.");

            return Ok(company);
        }

        [HttpPost("company")]
        public async Task<IActionResult> AddCompany(Company company)
        {
            var exists = (await _service.GetCompanies())
                .Any(x => x.CompanyName.Trim().ToLower() == company.CompanyName.Trim().ToLower());

            if (exists)
                return Conflict("Company already exists.");

            var result = await _service.AddCompany(company);

            return Ok(result);
        }

        [HttpPut("company/{id}")]
        public async Task<IActionResult> UpdateCompany(int id, Company company)
        {
            var existing = await _service.GetCompanyById(id);

            if (existing == null)
                return NotFound("Company not found.");

            var duplicate = (await _service.GetCompanies())
                .Any(x => x.CompanyId != id &&
                         x.CompanyName.Trim().ToLower() == company.CompanyName.Trim().ToLower());

            if (duplicate)
                return Conflict("Company already exists.");

            existing.CompanyName = company.CompanyName;
            existing.IsActive = company.IsActive;

            var result = await _service.UpdateCompany(existing);

            return Ok(result);
        }

        [HttpDelete("company/{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var existing = await _service.GetCompanyById(id);

            if (existing == null)
                return NotFound("Company not found.");

            await _service.DeleteCompany(id);

            return Ok("Company deleted successfully.");
        }


        // ==================== BRANCH ====================

        [HttpGet("branches")]
        public async Task<IActionResult> GetBranches()
        {
            return Ok(await _service.GetBranches());
        }

        [HttpGet("branch/{id}")]
        public async Task<IActionResult> GetBranchById(int id)
        {
            var branch = await _service.GetBranchById(id);

            if (branch == null)
                return NotFound("Branch not found.");

            return Ok(branch);
        }

        [HttpPost("branch")]
        public async Task<IActionResult> AddBranch(Branch branch)
        {
            var exists = (await _service.GetBranches())
                .Any(x => x.BranchName.Trim().ToLower() == branch.BranchName.Trim().ToLower()
                       && x.CompanyId == branch.CompanyId);

            if (exists)
                return Conflict("Branch already exists for this company.");

            var result = await _service.AddBranch(branch);

            return Ok(result);
        }

        [HttpPut("branch/{id}")]
        public async Task<IActionResult> UpdateBranch(int id, Branch branch)
        {
            var existing = await _service.GetBranchById(id);

            if (existing == null)
                return NotFound("Branch not found.");

            var duplicate = (await _service.GetBranches())
                .Any(x => x.BranchId != id &&
                         x.BranchName.Trim().ToLower() == branch.BranchName.Trim().ToLower()
                         && x.CompanyId == branch.CompanyId);

            if (duplicate)
                return Conflict("Branch already exists for this company.");

            existing.BranchName = branch.BranchName;
            existing.CompanyId = branch.CompanyId;
            existing.IsActive = branch.IsActive;

            var result = await _service.UpdateBranch(existing);

            return Ok(result);
        }

        [HttpDelete("branch/{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            var existing = await _service.GetBranchById(id);

            if (existing == null)
                return NotFound("Branch not found.");

            await _service.DeleteBranch(id);

            return Ok("Branch deleted successfully.");
        }


        // ==================== LOCATION ====================

        [HttpGet("locations")]
        public async Task<IActionResult> GetLocations()
        {
            return Ok(await _service.GetLocations());
        }

        [HttpGet("location/{id}")]
        public async Task<IActionResult> GetLocationById(int id)
        {
            var location = await _service.GetLocationById(id);

            if (location == null)
                return NotFound("Location not found.");

            return Ok(location);
        }

        [HttpPost("location")]
        public async Task<IActionResult> AddLocation(Location location)
        {
            var exists = (await _service.GetLocations())
                .Any(x => x.LocationName.Trim().ToLower() == location.LocationName.Trim().ToLower()
                       && x.BranchId == location.BranchId);

            if (exists)
                return Conflict("Location already exists for this branch.");

            var result = await _service.AddLocation(location);

            return Ok(result);
        }

        [HttpPut("location/{id}")]
        public async Task<IActionResult> UpdateLocation(int id, Location location)
        {
            var existing = await _service.GetLocationById(id);

            if (existing == null)
                return NotFound("Location not found.");

            var duplicate = (await _service.GetLocations())
                .Any(x => x.LocationId != id &&
                         x.LocationName.Trim().ToLower() == location.LocationName.Trim().ToLower()
                         && x.BranchId == location.BranchId);

            if (duplicate)
                return Conflict("Location already exists for this branch.");

            existing.LocationName = location.LocationName;
            existing.BranchId = location.BranchId;
            existing.IsActive = location.IsActive;

            var result = await _service.UpdateLocation(existing);

            return Ok(result);
        }

        [HttpDelete("location/{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            var existing = await _service.GetLocationById(id);

            if (existing == null)
                return NotFound("Location not found.");

            await _service.DeleteLocation(id);

            return Ok("Location deleted successfully.");
        }


        // ==================== BUSINESS UNIT ====================

        [HttpGet("business-units")]
        public async Task<IActionResult> GetBusinessUnits()
        {
            return Ok(await _service.GetBusinessUnits());
        }

        [HttpGet("business-unit/{id}")]
        public async Task<IActionResult> GetBusinessUnitById(int id)
        {
            var businessUnit = await _service.GetBusinessUnitById(id);

            if (businessUnit == null)
                return NotFound("Business Unit not found.");

            return Ok(businessUnit);
        }

        [HttpPost("business-unit")]
        public async Task<IActionResult> AddBusinessUnit(BusinessUnit businessUnit)
        {
            var exists = (await _service.GetBusinessUnits())
                .Any(x => x.BusinessUnitName.Trim().ToLower()
                            == businessUnit.BusinessUnitName.Trim().ToLower()
                       && x.CompanyId == businessUnit.CompanyId);

            if (exists)
                return Conflict("Business Unit already exists for this company.");

            var result = await _service.AddBusinessUnit(businessUnit);

            return Ok(result);
        }

        [HttpPut("business-unit/{id}")]
        public async Task<IActionResult> UpdateBusinessUnit(int id, BusinessUnit businessUnit)
        {
            var existing = await _service.GetBusinessUnitById(id);

            if (existing == null)
                return NotFound("Business Unit not found.");

            var duplicate = (await _service.GetBusinessUnits())
                .Any(x => x.BusinessUnitId != id &&
                         x.BusinessUnitName.Trim().ToLower()
                            == businessUnit.BusinessUnitName.Trim().ToLower()
                         && x.CompanyId == businessUnit.CompanyId);

            if (duplicate)
                return Conflict("Business Unit already exists for this company.");

            existing.BusinessUnitName = businessUnit.BusinessUnitName;
            existing.CompanyId = businessUnit.CompanyId;
            existing.IsActive = businessUnit.IsActive;

            var result = await _service.UpdateBusinessUnit(existing);

            return Ok(result);
        }

        [HttpDelete("business-unit/{id}")]
        public async Task<IActionResult> DeleteBusinessUnit(int id)
        {
            var existing = await _service.GetBusinessUnitById(id);

            if (existing == null)
                return NotFound("Business Unit not found.");

            await _service.DeleteBusinessUnit(id);

            return Ok("Business Unit deleted successfully.");
        }


        // ==================== COST CENTER ====================

        [HttpGet("cost-centers")]
        public async Task<IActionResult> GetCostCenters()
        {
            return Ok(await _service.GetCostCenters());
        }

        [HttpGet("cost-center/{id}")]
        public async Task<IActionResult> GetCostCenterById(int id)
        {
            var costCenter = await _service.GetCostCenterById(id);

            if (costCenter == null)
                return NotFound("Cost Center not found.");

            return Ok(costCenter);
        }

        [HttpPost("cost-center")]
        public async Task<IActionResult> AddCostCenter(CostCenter costCenter)
        {
            var exists = (await _service.GetCostCenters())
                .Any(x => x.CostCenterName.Trim().ToLower()
                            == costCenter.CostCenterName.Trim().ToLower()
                       && x.CompanyId == costCenter.CompanyId);

            if (exists)
                return Conflict("Cost Center already exists for this company.");

            var result = await _service.AddCostCenter(costCenter);

            return Ok(result);
        }

        [HttpPut("cost-center/{id}")]
        public async Task<IActionResult> UpdateCostCenter(int id, CostCenter costCenter)
        {
            var existing = await _service.GetCostCenterById(id);

            if (existing == null)
                return NotFound("Cost Center not found.");

            var duplicate = (await _service.GetCostCenters())
                .Any(x => x.CostCenterId != id &&
                         x.CostCenterName.Trim().ToLower()
                            == costCenter.CostCenterName.Trim().ToLower()
                         && x.CompanyId == costCenter.CompanyId);

            if (duplicate)
                return Conflict("Cost Center already exists for this company.");

            existing.CostCenterName = costCenter.CostCenterName;
            existing.CompanyId = costCenter.CompanyId;
            existing.IsActive = costCenter.IsActive;

            var result = await _service.UpdateCostCenter(existing);

            return Ok(result);
        }

        [HttpDelete("cost-center/{id}")]
        public async Task<IActionResult> DeleteCostCenter(int id)
        {
            var existing = await _service.GetCostCenterById(id);

            if (existing == null)
                return NotFound("Cost Center not found.");

            await _service.DeleteCostCenter(id);

            return Ok("Cost Center deleted successfully.");
        }
    }
}