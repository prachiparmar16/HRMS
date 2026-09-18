using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IGenderRepository
    {
        Task<List<Gender>> GetGenders();
        Task<Gender?> GetGenderById(int genderId);
        Task<Gender> AddGender(Gender gender);
        Task<Gender?> UpdateGender(Gender gender);
        Task<bool> DeleteGender(int genderId);
    }
}
