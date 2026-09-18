using HRMS.Models.ModelClasses;

namespace HRMS.WebAPI.Repositories
{
    public interface IRecruitmentMasterRepository
    {
        // =========================
        // SKILL
        // =========================

        Task<List<Skill>> GetSkills();
        Task<Skill?> GetSkillById(int skillId);
        Task<Skill> AddSkill(Skill skill);
        Task<Skill?> UpdateSkill(Skill skill);
        Task<bool> DeleteSkill(int skillId);


        // =========================
        // QUALIFICATION
        // =========================

        Task<List<Qualification>> GetQualifications();
        Task<Qualification?> GetQualificationById(int qualificationId);
        Task<Qualification> AddQualification(Qualification qualification);
        Task<Qualification?> UpdateQualification(Qualification qualification);
        Task<bool> DeleteQualification(int qualificationId);


        // =========================
        // CERTIFICATION
        // =========================

        Task<List<Certification>> GetCertifications();
        Task<Certification?> GetCertificationById(int certificationId);
        Task<Certification> AddCertification(Certification certification);
        Task<Certification?> UpdateCertification(Certification certification);
        Task<bool> DeleteCertification(int certificationId);


        // =========================
        // JOB TYPE
        // =========================

        Task<List<JobType>> GetJobTypes();
        Task<JobType?> GetJobTypeById(int jobTypeId);
        Task<JobType> AddJobType(JobType jobType);
        Task<JobType?> UpdateJobType(JobType jobType);
        Task<bool> DeleteJobType(int jobTypeId);


        // =========================
        // INTERVIEW TYPE
        // =========================

        Task<List<InterviewType>> GetInterviewTypes();
        Task<InterviewType?> GetInterviewTypeById(int interviewTypeId);
        Task<InterviewType> AddInterviewType(InterviewType interviewType);
        Task<InterviewType?> UpdateInterviewType(InterviewType interviewType);
        Task<bool> DeleteInterviewType(int interviewTypeId);


        // =========================
        // INTERVIEW STATUS
        // =========================

        Task<List<InterviewStatus>> GetInterviewStatuses();
        Task<InterviewStatus?> GetInterviewStatusById(int interviewStatusId);
        Task<InterviewStatus> AddInterviewStatus(InterviewStatus interviewStatus);
        Task<InterviewStatus?> UpdateInterviewStatus(InterviewStatus interviewStatus);
        Task<bool> DeleteInterviewStatus(int interviewStatusId);


        // =========================
        // RECRUITMENT SOURCE
        // =========================

        Task<List<RecruitmentSource>> GetRecruitmentSources();
        Task<RecruitmentSource?> GetRecruitmentSourceById(int recruitmentSourceId);
        Task<RecruitmentSource> AddRecruitmentSource(RecruitmentSource recruitmentSource);
        Task<RecruitmentSource?> UpdateRecruitmentSource(RecruitmentSource recruitmentSource);
        Task<bool> DeleteRecruitmentSource(int recruitmentSourceId);
    }
}