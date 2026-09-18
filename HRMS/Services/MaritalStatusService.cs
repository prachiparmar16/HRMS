using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class MaritalStatusService : IMaritalStatusRepository
    {
        private readonly HrmsDbContext _db;

        public MaritalStatusService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<MaritalStatus>> GetMaritalStatuses()
            => await _db.MaritalStatustbl.ToListAsync();

        public async Task<MaritalStatus?> GetMaritalStatusById(int maritalStatusId)
            => await _db.MaritalStatustbl
                .FirstOrDefaultAsync(x => x.MaritalStatusId == maritalStatusId);

        public async Task<MaritalStatus> AddMaritalStatus(
            MaritalStatus maritalStatus)
        {
            _db.MaritalStatustbl.Add(maritalStatus);
            await _db.SaveChangesAsync();
            return maritalStatus;
        }

        public async Task<MaritalStatus?> UpdateMaritalStatus(
            MaritalStatus maritalStatus)
        {
            var existing = await _db.MaritalStatustbl
                .FirstOrDefaultAsync(x =>
                    x.MaritalStatusId == maritalStatus.MaritalStatusId);

            if (existing == null)
                return null;

            existing.StatusName = maritalStatus.StatusName;
            existing.IsActive = maritalStatus.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteMaritalStatus(int maritalStatusId)
        {
            var maritalStatus = await _db.MaritalStatustbl
                .FirstOrDefaultAsync(x =>
                    x.MaritalStatusId == maritalStatusId);

            if (maritalStatus == null)
                return false;

            _db.MaritalStatustbl.Remove(maritalStatus);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
