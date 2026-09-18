using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IOrganizationMasterRepository
    {
        // Company
        Task<List<Company>> GetCompanies();
        Task<Company?> GetCompanyById(int companyId);
        Task<Company> AddCompany(Company company);
        Task<Company?> UpdateCompany(Company company);
        Task<bool> DeleteCompany(int companyId);

        // Branch
        Task<List<Branch>> GetBranches();
        Task<Branch?> GetBranchById(int branchId);
        Task<Branch> AddBranch(Branch branch);
        Task<Branch?> UpdateBranch(Branch branch);
        Task<bool> DeleteBranch(int branchId);

        // Location
        Task<List<Location>> GetLocations();
        Task<Location?> GetLocationById(int locationId);
        Task<Location> AddLocation(Location location);
        Task<Location?> UpdateLocation(Location location);
        Task<bool> DeleteLocation(int locationId);

        // Business Unit
        Task<List<BusinessUnit>> GetBusinessUnits();
        Task<BusinessUnit?> GetBusinessUnitById(int businessUnitId);
        Task<BusinessUnit> AddBusinessUnit(BusinessUnit businessUnit);
        Task<BusinessUnit?> UpdateBusinessUnit(BusinessUnit businessUnit);
        Task<bool> DeleteBusinessUnit(int businessUnitId);

        // Cost Center
        Task<List<CostCenter>> GetCostCenters();
        Task<CostCenter?> GetCostCenterById(int costCenterId);
        Task<CostCenter> AddCostCenter(CostCenter costCenter);
        Task<CostCenter?> UpdateCostCenter(CostCenter costCenter);
        Task<bool> DeleteCostCenter(int costCenterId);
    }
}