using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class OrganizationMasterService : IOrganizationMasterRepository
    {
        private readonly HrmsDbContext _db;

        public OrganizationMasterService(HrmsDbContext db)
        {
            _db = db;
        }

        // =========================
        // COMPANY
        // =========================

        public async Task<List<Company>> GetCompanies()
        {
            return await _db.Companiestbl
                .ToListAsync();
        }

        public async Task<Company?> GetCompanyById(int companyId)
        {
            return await _db.Companiestbl
                .FirstOrDefaultAsync(x =>
                    x.CompanyId == companyId);
        }

        public async Task<Company> AddCompany(Company company)
        {
            _db.Companiestbl.Add(company);

            await _db.SaveChangesAsync();

            return company;
        }

        public async Task<Company?> UpdateCompany(Company company)
        {
            var existingCompany =
                await _db.Companiestbl
                .FirstOrDefaultAsync(x =>
                    x.CompanyId == company.CompanyId);

            if (existingCompany == null)
                return null;

            existingCompany.CompanyName =
                company.CompanyName;

            existingCompany.IsActive =
                company.IsActive;

            await _db.SaveChangesAsync();

            return existingCompany;
        }

        public async Task<bool> DeleteCompany(int companyId)
        {
            var company =
                await _db.Companiestbl
                .FirstOrDefaultAsync(x =>
                    x.CompanyId == companyId);

            if (company == null)
                return false;

            _db.Companiestbl.Remove(company);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // BRANCH
        // =========================

        public async Task<List<Branch>> GetBranches()
        {
            return await _db.Branchestbl
                .Include(x => x.Company)
                .ToListAsync();
        }

        public async Task<Branch?> GetBranchById(int branchId)
        {
            return await _db.Branchestbl
                .Include(x => x.Company)
                .FirstOrDefaultAsync(x =>
                    x.BranchId == branchId);
        }

        public async Task<Branch> AddBranch(Branch branch)
        {
            _db.Branchestbl.Add(branch);

            await _db.SaveChangesAsync();

            return branch;
        }

        public async Task<Branch?> UpdateBranch(Branch branch)
        {
            var existingBranch =
                await _db.Branchestbl
                .FirstOrDefaultAsync(x =>
                    x.BranchId == branch.BranchId);

            if (existingBranch == null)
                return null;

            existingBranch.BranchName =
                branch.BranchName;

            existingBranch.CompanyId =
                branch.CompanyId;

            existingBranch.IsActive =
                branch.IsActive;

            await _db.SaveChangesAsync();

            return existingBranch;
        }

        public async Task<bool> DeleteBranch(int branchId)
        {
            var branch =
                await _db.Branchestbl
                .FirstOrDefaultAsync(x =>
                    x.BranchId == branchId);

            if (branch == null)
                return false;

            _db.Branchestbl.Remove(branch);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // LOCATION
        // =========================

        public async Task<List<Location>> GetLocations()
        {
            return await _db.Locationstbl
                .Include(x => x.Branch)
                .ToListAsync();
        }

        public async Task<Location?> GetLocationById(int locationId)
        {
            return await _db.Locationstbl
                .Include(x => x.Branch)
                .FirstOrDefaultAsync(x =>
                    x.LocationId == locationId);
        }

        public async Task<Location> AddLocation(Location location)
        {
            _db.Locationstbl.Add(location);

            await _db.SaveChangesAsync();

            return location;
        }

        public async Task<Location?> UpdateLocation(Location location)
        {
            var existingLocation =
                await _db.Locationstbl
                .FirstOrDefaultAsync(x =>
                    x.LocationId == location.LocationId);

            if (existingLocation == null)
                return null;

            existingLocation.LocationName =
                location.LocationName;

            existingLocation.BranchId =
                location.BranchId;

            existingLocation.IsActive =
                location.IsActive;

            await _db.SaveChangesAsync();

            return existingLocation;
        }

        public async Task<bool> DeleteLocation(int locationId)
        {
            var location =
                await _db.Locationstbl
                .FirstOrDefaultAsync(x =>
                    x.LocationId == locationId);

            if (location == null)
                return false;

            _db.Locationstbl.Remove(location);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // BUSINESS UNIT
        // =========================

        public async Task<List<BusinessUnit>> GetBusinessUnits()
        {
            return await _db.BusinessUnitstbl
                .Include(x => x.Company)
                .ToListAsync();
        }

        public async Task<BusinessUnit?> GetBusinessUnitById(
            int businessUnitId)
        {
            return await _db.BusinessUnitstbl
                .Include(x => x.Company)
                .FirstOrDefaultAsync(x =>
                    x.BusinessUnitId == businessUnitId);
        }

        public async Task<BusinessUnit> AddBusinessUnit(
            BusinessUnit businessUnit)
        {
            _db.BusinessUnitstbl.Add(businessUnit);

            await _db.SaveChangesAsync();

            return businessUnit;
        }

        public async Task<BusinessUnit?> UpdateBusinessUnit(
            BusinessUnit businessUnit)
        {
            var existingBusinessUnit =
                await _db.BusinessUnitstbl
                .FirstOrDefaultAsync(x =>
                    x.BusinessUnitId ==
                    businessUnit.BusinessUnitId);

            if (existingBusinessUnit == null)
                return null;

            existingBusinessUnit.BusinessUnitName =
                businessUnit.BusinessUnitName;

            existingBusinessUnit.CompanyId =
                businessUnit.CompanyId;

            existingBusinessUnit.IsActive =
                businessUnit.IsActive;

            await _db.SaveChangesAsync();

            return existingBusinessUnit;
        }

        public async Task<bool> DeleteBusinessUnit(
            int businessUnitId)
        {
            var businessUnit =
                await _db.BusinessUnitstbl
                .FirstOrDefaultAsync(x =>
                    x.BusinessUnitId == businessUnitId);

            if (businessUnit == null)
                return false;

            _db.BusinessUnitstbl.Remove(businessUnit);

            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // COST CENTER
        // =========================

        public async Task<List<CostCenter>> GetCostCenters()
        {
            return await _db.CostCenterstbl
                .Include(x => x.Company)
                .ToListAsync();
        }

        public async Task<CostCenter?> GetCostCenterById(
            int costCenterId)
        {
            return await _db.CostCenterstbl
                .Include(x => x.Company)
                .FirstOrDefaultAsync(x =>
                    x.CostCenterId == costCenterId);
        }

        public async Task<CostCenter> AddCostCenter(
            CostCenter costCenter)
        {
            _db.CostCenterstbl.Add(costCenter);

            await _db.SaveChangesAsync();

            return costCenter;
        }

        public async Task<CostCenter?> UpdateCostCenter(
            CostCenter costCenter)
        {
            var existingCostCenter =
                await _db.CostCenterstbl
                .FirstOrDefaultAsync(x =>
                    x.CostCenterId ==
                    costCenter.CostCenterId);

            if (existingCostCenter == null)
                return null;

            existingCostCenter.CostCenterName =
                costCenter.CostCenterName;

            existingCostCenter.CompanyId =
                costCenter.CompanyId;

            existingCostCenter.IsActive =
                costCenter.IsActive;

            await _db.SaveChangesAsync();

            return existingCostCenter;
        }

        public async Task<bool> DeleteCostCenter(
            int costCenterId)
        {
            var costCenter =
                await _db.CostCenterstbl
                .FirstOrDefaultAsync(x =>
                    x.CostCenterId == costCenterId);

            if (costCenter == null)
                return false;

            _db.CostCenterstbl.Remove(costCenter);

            await _db.SaveChangesAsync();

            return true;
        }
    }
}