using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;



namespace HRMS.WebAPI.Services
{
    public class LanguageService : ILanguageRepository
    {
        private readonly HrmsDbContext _db;

        public LanguageService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<Language>> GetLanguages()
            => await _db.Languagetbl.ToListAsync();

        public async Task<Language?> GetLanguageById(int languageId)
            => await _db.Languagetbl
                .FirstOrDefaultAsync(x => x.LanguageId == languageId);

        public async Task<Language> AddLanguage(Language language)
        {
            _db.Languagetbl.Add(language);
            await _db.SaveChangesAsync();
            return language;
        }

        public async Task<Language?> UpdateLanguage(Language language)
        {
            var existing = await _db.Languagetbl
                .FirstOrDefaultAsync(x => x.LanguageId == language.LanguageId);

            if (existing == null)
                return null;

            existing.LanguageName = language.LanguageName;
            existing.IsActive = language.IsActive;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteLanguage(int languageId)
        {
            var language = await _db.Languagetbl
                .FirstOrDefaultAsync(x => x.LanguageId == languageId);

            if (language == null)
                return false;

            _db.Languagetbl.Remove(language);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
