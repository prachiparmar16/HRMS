using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class BloodGroupService : IBloodGroupRepository
    {
        private readonly HrmsDbContext _db;

        public BloodGroupService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<BloodGroup>> GetBloodGroups()
            => await _db.BloodGrouptbl.ToListAsync();

        public async Task<BloodGroup?> GetBloodGroupById(int bloodGroupId)
            => await _db.BloodGrouptbl
                .FirstOrDefaultAsync(x => x.BloodGroupId == bloodGroupId);

        public async Task<BloodGroup> AddBloodGroup(BloodGroup bloodGroup)
        {
            _db.BloodGrouptbl.Add(bloodGroup);
            await _db.SaveChangesAsync();
            return bloodGroup;
        }

        public async Task<BloodGroup?> UpdateBloodGroup(BloodGroup bloodGroup)
        {
            var existing = await _db.BloodGrouptbl
                .FirstOrDefaultAsync(x => x.BloodGroupId == bloodGroup.BloodGroupId);

            if (existing == null)
                return null;

            existing.BloodGroupName = bloodGroup.BloodGroupName;
            existing.IsActive = bloodGroup.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteBloodGroup(int bloodGroupId)
        {
            var bloodGroup = await _db.BloodGrouptbl
                .FirstOrDefaultAsync(x => x.BloodGroupId == bloodGroupId);

            if (bloodGroup == null)
                return false;

            _db.BloodGrouptbl.Remove(bloodGroup);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
