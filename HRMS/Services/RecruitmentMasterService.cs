using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HRMS.WebAPI.Services
{
    public class RecruitmentMasterService : IRecruitmentMasterRepository
    {
        private readonly HrmsDbContext _db;

        public RecruitmentMasterService(HrmsDbContext db)
        {
            _db = db;
        }

        // =========================
        // SKILL
        // =========================

        public async Task<List<Skill>> GetSkills()
        {
            return await _db.Skillstbl
                .ToListAsync();
        }

        public async Task<Skill?> GetSkillById(int skillId)
        {
            return await _db.Skillstbl
                .FirstOrDefaultAsync(x => x.SkillId == skillId);
        }

        public async Task<Skill> AddSkill(Skill skill)
        {
            _db.Skillstbl.Add(skill);
            await _db.SaveChangesAsync();

            return skill;
        }

        public async Task<Skill?> UpdateSkill(Skill skill)
        {
            var existingSkill = await _db.Skillstbl
                .FirstOrDefaultAsync(x => x.SkillId == skill.SkillId);

            if (existingSkill == null)
                return null;

            existingSkill.SkillName = skill.SkillName;
            existingSkill.IsActive = skill.IsActive;

            await _db.SaveChangesAsync();

            return existingSkill;
        }

        public async Task<bool> DeleteSkill(int skillId)
        {
            var skill = await _db.Skillstbl
                .FirstOrDefaultAsync(x => x.SkillId == skillId);

            if (skill == null)
                return false;

            _db.Skillstbl.Remove(skill);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // QUALIFICATION
        // =========================

        public async Task<List<Qualification>> GetQualifications()
        {
            return await _db.Qualificationstbl
                .ToListAsync();
        }

        public async Task<Qualification?> GetQualificationById(int qualificationId)
        {
            return await _db.Qualificationstbl
                .FirstOrDefaultAsync(x =>
                    x.QualificationId == qualificationId);
        }

        public async Task<Qualification> AddQualification(
            Qualification qualification)
        {
            _db.Qualificationstbl.Add(qualification);
            await _db.SaveChangesAsync();

            return qualification;
        }

        public async Task<Qualification?> UpdateQualification(
            Qualification qualification)
        {
            var existingQualification =
                await _db.Qualificationstbl
                .FirstOrDefaultAsync(x =>
                    x.QualificationId == qualification.QualificationId);

            if (existingQualification == null)
                return null;

            existingQualification.QualificationName =
                qualification.QualificationName;

            existingQualification.IsActive =
                qualification.IsActive;

            await _db.SaveChangesAsync();

            return existingQualification;
        }

        public async Task<bool> DeleteQualification(int qualificationId)
        {
            var qualification =
                await _db.Qualificationstbl
                .FirstOrDefaultAsync(x =>
                    x.QualificationId == qualificationId);

            if (qualification == null)
                return false;

            _db.Qualificationstbl.Remove(qualification);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // CERTIFICATION
        // =========================

        public async Task<List<Certification>> GetCertifications()
        {
            return await _db.Certificationstbl
                .ToListAsync();
        }

        public async Task<Certification?> GetCertificationById(
            int certificationId)
        {
            return await _db.Certificationstbl
                .FirstOrDefaultAsync(x =>
                    x.CertificationId == certificationId);
        }

        public async Task<Certification> AddCertification(
            Certification certification)
        {
            _db.Certificationstbl.Add(certification);
            await _db.SaveChangesAsync();

            return certification;
        }

        public async Task<Certification?> UpdateCertification(
            Certification certification)
        {
            var existingCertification =
                await _db.Certificationstbl
                .FirstOrDefaultAsync(x =>
                    x.CertificationId == certification.CertificationId);

            if (existingCertification == null)
                return null;

            existingCertification.CertificationName =
                certification.CertificationName;

            existingCertification.IsActive =
                certification.IsActive;

            await _db.SaveChangesAsync();

            return existingCertification;
        }

        public async Task<bool> DeleteCertification(
            int certificationId)
        {
            var certification =
                await _db.Certificationstbl
                .FirstOrDefaultAsync(x =>
                    x.CertificationId == certificationId);

            if (certification == null)
                return false;

            _db.Certificationstbl.Remove(certification);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // JOB TYPE
        // =========================

        public async Task<List<JobType>> GetJobTypes()
        {
            return await _db.JobTypestbl
                .ToListAsync();
        }

        public async Task<JobType?> GetJobTypeById(int jobTypeId)
        {
            return await _db.JobTypestbl
                .FirstOrDefaultAsync(x =>
                    x.JobTypeId == jobTypeId);
        }

        public async Task<JobType> AddJobType(JobType jobType)
        {
            _db.JobTypestbl.Add(jobType);
            await _db.SaveChangesAsync();

            return jobType;
        }

        public async Task<JobType?> UpdateJobType(
            JobType jobType)
        {
            var existingJobType =
                await _db.JobTypestbl
                .FirstOrDefaultAsync(x =>
                    x.JobTypeId == jobType.JobTypeId);

            if (existingJobType == null)
                return null;

            existingJobType.JobTypeName =
                jobType.JobTypeName;

            existingJobType.IsActive =
                jobType.IsActive;

            await _db.SaveChangesAsync();

            return existingJobType;
        }

        public async Task<bool> DeleteJobType(int jobTypeId)
        {
            var jobType = await _db.JobTypestbl
                .FirstOrDefaultAsync(x =>
                    x.JobTypeId == jobTypeId);

            if (jobType == null)
                return false;

            _db.JobTypestbl.Remove(jobType);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // INTERVIEW TYPE
        // =========================

        public async Task<List<InterviewType>> GetInterviewTypes()
        {
            return await _db.InterviewTypestbl
                .ToListAsync();
        }

        public async Task<InterviewType?> GetInterviewTypeById(
            int interviewTypeId)
        {
            return await _db.InterviewTypestbl
                .FirstOrDefaultAsync(x =>
                    x.InterviewTypeId == interviewTypeId);
        }

        public async Task<InterviewType> AddInterviewType(
            InterviewType interviewType)
        {
            _db.InterviewTypestbl.Add(interviewType);
            await _db.SaveChangesAsync();

            return interviewType;
        }

        public async Task<InterviewType?> UpdateInterviewType(
            InterviewType interviewType)
        {
            var existingInterviewType =
                await _db.InterviewTypestbl
                .FirstOrDefaultAsync(x =>
                    x.InterviewTypeId ==
                    interviewType.InterviewTypeId);

            if (existingInterviewType == null)
                return null;

            existingInterviewType.InterviewTypeName =
                interviewType.InterviewTypeName;

            existingInterviewType.IsActive =
                interviewType.IsActive;

            await _db.SaveChangesAsync();

            return existingInterviewType;
        }

        public async Task<bool> DeleteInterviewType(
            int interviewTypeId)
        {
            var interviewType =
                await _db.InterviewTypestbl
                .FirstOrDefaultAsync(x =>
                    x.InterviewTypeId == interviewTypeId);

            if (interviewType == null)
                return false;

            _db.InterviewTypestbl.Remove(interviewType);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // INTERVIEW STATUS
        // =========================

        public async Task<List<InterviewStatus>> GetInterviewStatuses()
        {
            return await _db.InterviewStatustbl
                .ToListAsync();
        }

        public async Task<InterviewStatus?> GetInterviewStatusById(
            int interviewStatusId)
        {
            return await _db.InterviewStatustbl
                .FirstOrDefaultAsync(x =>
                    x.InterviewStatusId == interviewStatusId);
        }

        public async Task<InterviewStatus> AddInterviewStatus(
            InterviewStatus interviewStatus)
        {
            _db.InterviewStatustbl.Add(interviewStatus);
            await _db.SaveChangesAsync();

            return interviewStatus;
        }

        public async Task<InterviewStatus?> UpdateInterviewStatus(
            InterviewStatus interviewStatus)
        {
            var existingInterviewStatus =
                await _db.InterviewStatustbl
                .FirstOrDefaultAsync(x =>
                    x.InterviewStatusId ==
                    interviewStatus.InterviewStatusId);

            if (existingInterviewStatus == null)
                return null;

            existingInterviewStatus.InterviewStatusName =
                interviewStatus.InterviewStatusName;

            existingInterviewStatus.IsActive =
                interviewStatus.IsActive;

            await _db.SaveChangesAsync();

            return existingInterviewStatus;
        }

        public async Task<bool> DeleteInterviewStatus(
            int interviewStatusId)
        {
            var interviewStatus =
                await _db.InterviewStatustbl
                .FirstOrDefaultAsync(x =>
                    x.InterviewStatusId == interviewStatusId);

            if (interviewStatus == null)
                return false;

            _db.InterviewStatustbl.Remove(interviewStatus);
            await _db.SaveChangesAsync();

            return true;
        }


        // =========================
        // RECRUITMENT SOURCE
        // =========================

        public async Task<List<RecruitmentSource>> GetRecruitmentSources()
        {
            return await _db.RecruitmentSourcetbl
                .ToListAsync();
        }

        public async Task<RecruitmentSource?> GetRecruitmentSourceById(
            int recruitmentSourceId)
        {
            return await _db.RecruitmentSourcetbl
                .FirstOrDefaultAsync(x =>
                    x.RecruitmentSourceId == recruitmentSourceId);
        }

        public async Task<RecruitmentSource> AddRecruitmentSource(
            RecruitmentSource recruitmentSource)
        {
            _db.RecruitmentSourcetbl.Add(recruitmentSource);
            await _db.SaveChangesAsync();

            return recruitmentSource;
        }

        public async Task<RecruitmentSource?> UpdateRecruitmentSource(
            RecruitmentSource recruitmentSource)
        {
            var existingRecruitmentSource =
                await _db.RecruitmentSourcetbl
                .FirstOrDefaultAsync(x =>
                    x.RecruitmentSourceId ==
                    recruitmentSource.RecruitmentSourceId);

            if (existingRecruitmentSource == null)
                return null;

            existingRecruitmentSource.RecruitmentSourceName =
                recruitmentSource.RecruitmentSourceName;

            existingRecruitmentSource.IsActive =
                recruitmentSource.IsActive;

            await _db.SaveChangesAsync();

            return existingRecruitmentSource;
        }

        public async Task<bool> DeleteRecruitmentSource(
            int recruitmentSourceId)
        {
            var recruitmentSource =
                await _db.RecruitmentSourcetbl
                .FirstOrDefaultAsync(x =>
                    x.RecruitmentSourceId == recruitmentSourceId);

            if (recruitmentSource == null)
                return false;

            _db.RecruitmentSourcetbl.Remove(recruitmentSource);
            await _db.SaveChangesAsync();

            return true;
        }
    }
}