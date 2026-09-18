using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class TaxSlabService : ITaxSlabRepository
    {
        private readonly HrmsDbContext _db;

        public TaxSlabService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<TaxSlab>> GetTaxSlabs()
        {
            return await _db.TaxSlabstbl
                .ToListAsync();
        }

        public async Task<TaxSlab?> GetTaxSlabById(
            int taxSlabId)
        {
            return await _db.TaxSlabstbl
                .FirstOrDefaultAsync(x =>
                    x.TaxSlabId == taxSlabId);
        }

        public async Task<TaxSlab> AddTaxSlab(
            TaxSlab taxSlab)
        {
            taxSlab.IsActive = true;

            _db.TaxSlabstbl.Add(taxSlab);

            await _db.SaveChangesAsync();

            return taxSlab;
        }

        public async Task<TaxSlab?> UpdateTaxSlab(
            TaxSlab taxSlab)
        {
            var existingTaxSlab =
                await _db.TaxSlabstbl
                .FirstOrDefaultAsync(x =>
                    x.TaxSlabId == taxSlab.TaxSlabId);

            if (existingTaxSlab == null)
                return null;

            existingTaxSlab.SlabName =
                taxSlab.SlabName;

           
            existingTaxSlab.TaxPercentage =
                taxSlab.TaxPercentage;

            existingTaxSlab.IsActive =
                taxSlab.IsActive;

            await _db.SaveChangesAsync();

            return existingTaxSlab;
        }

        public async Task<bool> DeleteTaxSlab(
            int taxSlabId)
        {
            var taxSlab =
                await _db.TaxSlabstbl
                .FirstOrDefaultAsync(x =>
                    x.TaxSlabId == taxSlabId);

            if (taxSlab == null)
                return false;

            taxSlab.IsActive = false;

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
