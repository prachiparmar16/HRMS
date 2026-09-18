using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface ISalaryGradeRepository
    {

       Task<List<SalaryGrade>> GetSalaryGrades();

        Task<SalaryGrade?> GetSalaryGradeById(int salaryGradeId);

        Task<SalaryGrade> AddSalaryGrade(SalaryGrade salaryGrade);
       Task<SalaryGrade?> UpdateSalaryGrade(SalaryGrade salaryGrade);

        Task<bool> DeleteSalaryGrade(int salaryGradeId);
    }

}

