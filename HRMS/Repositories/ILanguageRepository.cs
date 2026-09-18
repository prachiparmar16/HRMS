using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ILanguageRepository


    {
        Task<List<Language>> GetLanguages();
        Task<Language?> GetLanguageById(int languageId);
        Task<Language> AddLanguage(Language language);
        Task<Language?> UpdateLanguage(Language language);
        Task<bool> DeleteLanguage(int languageId);
    }
}
