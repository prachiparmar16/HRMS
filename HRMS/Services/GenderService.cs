using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class GenderService : IGenderRepository
    {
        private readonly HrmsDbContext _db;

        public GenderService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<Gender>> GetGenders()
            => await _db.Gendertbl.ToListAsync();

        public async Task<Gender?> GetGenderById(int genderId)
            => await _db.Gendertbl
                .FirstOrDefaultAsync(x => x.GenderId == genderId);

        public async Task<Gender> AddGender(Gender gender)
        {
            _db.Gendertbl.Add(gender);
            await _db.SaveChangesAsync();
            return gender;
        }

        public async Task<Gender?> UpdateGender(Gender gender)
        {
            var existing = await _db.Gendertbl
                .FirstOrDefaultAsync(x => x.GenderId == gender.GenderId);

            if (existing == null)
                return null;

            existing.GenderName = gender.GenderName;
            existing.IsActive = gender.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteGender(int genderId)
        {
            var gender = await _db.Gendertbl
                .FirstOrDefaultAsync(x => x.GenderId == genderId);

            if (gender == null)
                return false;

            _db.Gendertbl.Remove(gender);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
