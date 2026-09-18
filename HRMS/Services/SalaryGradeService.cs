using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;


namespace HRMS.WebAPI.Services
{
    public class SalaryGradeService : ISalaryGradeRepository
    {
        private readonly HrmsDbContext _db;

        public SalaryGradeService(HrmsDbContext db)
        {
            _db = db;
        }

        public async Task<List<SalaryGrade>> GetSalaryGrades()
        {
            return await _db.SalaryGradestbl
                .ToListAsync();
        }

        public async Task<SalaryGrade?> GetSalaryGradeById(
            int salaryGradeId)
        {
            return await _db.SalaryGradestbl
                .FirstOrDefaultAsync(x =>
                    x.SalaryGradeId == salaryGradeId);
        }

        public async Task<SalaryGrade> AddSalaryGrade(
            SalaryGrade salaryGrade)
        {
            salaryGrade.IsActive = true;

            _db.SalaryGradestbl.Add(salaryGrade);

            await _db.SaveChangesAsync();

            return salaryGrade;
        }

        public async Task<SalaryGrade?> UpdateSalaryGrade(
            SalaryGrade salaryGrade)
        {
            var existingSalaryGrade =
                await _db.SalaryGradestbl
                .FirstOrDefaultAsync(x =>
                    x.SalaryGradeId ==
                    salaryGrade.SalaryGradeId);

            if (existingSalaryGrade == null)
                return null;

           

            existingSalaryGrade.GradeName =
                salaryGrade.GradeName;

            existingSalaryGrade.MinimumSalary =
                salaryGrade.MinimumSalary;

            existingSalaryGrade.MaximumSalary =
                salaryGrade.MaximumSalary;

            existingSalaryGrade.IsActive =
                salaryGrade.IsActive;

            await _db.SaveChangesAsync();

            return existingSalaryGrade;
        }

        public async Task<bool> DeleteSalaryGrade(
            int salaryGradeId)
        {
            var salaryGrade =
                await _db.SalaryGradestbl
                .FirstOrDefaultAsync(x =>
                    x.SalaryGradeId == salaryGradeId);

            if (salaryGrade == null)
                return false;

            salaryGrade.IsActive = false;

            await _db.SaveChangesAsync();

            return true;
        }
    }
}
