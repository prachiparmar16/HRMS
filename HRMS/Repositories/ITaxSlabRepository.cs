using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ITaxSlabRepository
    {
         Task<List<TaxSlab>> GetTaxSlabs();

         Task<TaxSlab?> GetTaxSlabById(int taxSlabId);

         Task<TaxSlab> AddTaxSlab(TaxSlab taxSlab);
         Task<TaxSlab?> UpdateTaxSlab(TaxSlab taxSlab);

         Task<bool> DeleteTaxSlab(int taxSlabId);
    }
}
