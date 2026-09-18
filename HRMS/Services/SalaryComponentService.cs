using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using HRMS.Models.ModelClasses;


namespace HRMS.WebAPI.Services
{
    public class SalaryComponentService : ISalaryComponentRepository
    {
        private readonly HrmsDbContext _db;

        public SalaryComponentService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<SalaryComponent>> GetSalaryComponents()
        {
            return await _db.SalaryComponentstbl
                .ToListAsync();
        }

        public async Task<SalaryComponent?> GetSalaryComponentById(
            int salaryComponentId)
        {
            return await _db.SalaryComponentstbl
                .FirstOrDefaultAsync(x =>
                    x.SalaryComponentId == salaryComponentId);
        }

        public async Task<SalaryComponent> AddSalaryComponent(
            SalaryComponent salaryComponent)
        {
            salaryComponent.IsActive = true;

            _db.SalaryComponentstbl.Add(salaryComponent);

            await _db.SaveChangesAsync();

            return salaryComponent;
        }

        public async Task<SalaryComponent?> UpdateSalaryComponent(
            SalaryComponent salaryComponent)
        {
            var existingSalaryComponent =
                await _db.SalaryComponentstbl
                .FirstOrDefaultAsync(x =>
                    x.SalaryComponentId ==
                    salaryComponent.SalaryComponentId);

            if (existingSalaryComponent == null)
                return null;

            existingSalaryComponent.ComponentName =
                salaryComponent.ComponentName;

            
            existingSalaryComponent.ComponentType =
                salaryComponent.ComponentType;

            existingSalaryComponent.IsActive =
                salaryComponent.IsActive;

            await _db.SaveChangesAsync();

            return existingSalaryComponent;
        }

        public async Task<bool> DeleteSalaryComponent(
            int salaryComponentId)
        {
            var salaryComponent =
                await _db.SalaryComponentstbl
                .FirstOrDefaultAsync(x =>
                    x.SalaryComponentId == salaryComponentId);

            if (salaryComponent == null)
                return false;

            salaryComponent.IsActive = false;

            await _db.SaveChangesAsync();

            return true;
        }
    }
}