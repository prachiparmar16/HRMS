using HRMS.Models.ModelClasses;
using HRMS.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecruitmentMasterController : ControllerBase
    {
        private readonly IRecruitmentMasterRepository _service;

        public RecruitmentMasterController(IRecruitmentMasterRepository service)
        {
            _service = service;
        }

        // ==================== SKILL ====================

        [HttpGet("skills")]
        public async Task<IActionResult> GetSkills()
        {
            return Ok(await _service.GetSkills());
        }

        [HttpGet("skill/{id}")]
        public async Task<IActionResult> GetSkillById(int id)
        {
            var skill = await _service.GetSkillById(id);

            if (skill == null)
                return NotFound("Skill not found.");

            return Ok(skill);
        }

        [HttpPost("skill")]
        public async Task<IActionResult> AddSkill(Skill skill)
        {
            var exists = (await _service.GetSkills())
                .Any(x => x.SkillName.Trim().ToLower()
                    == skill.SkillName.Trim().ToLower());

            if (exists)
                return Conflict("Skill already exists.");

            var result = await _service.AddSkill(skill);

            return Ok(result);
        }

        [HttpPut("skill/{id}")]
        public async Task<IActionResult> UpdateSkill(int id, Skill skill)
        {
            var existing = await _service.GetSkillById(id);

            if (existing == null)
                return NotFound("Skill not found.");

            var duplicate = (await _service.GetSkills())
                .Any(x => x.SkillId != id &&
                         x.SkillName.Trim().ToLower()
                            == skill.SkillName.Trim().ToLower());

            if (duplicate)
                return Conflict("Skill already exists.");

            existing.SkillName = skill.SkillName;
            existing.IsActive = skill.IsActive;

            var result = await _service.UpdateSkill(existing);

            return Ok(result);
        }

        [HttpDelete("skill/{id}")]
        public async Task<IActionResult> DeleteSkill(int id)
        {
            var existing = await _service.GetSkillById(id);

            if (existing == null)
                return NotFound("Skill not found.");

            await _service.DeleteSkill(id);

            return Ok("Skill deleted successfully.");
        }


        // ==================== QUALIFICATION ====================

        [HttpGet("qualifications")]
        public async Task<IActionResult> GetQualifications()
        {
            return Ok(await _service.GetQualifications());
        }

        [HttpGet("qualification/{id}")]
        public async Task<IActionResult> GetQualificationById(int id)
        {
            var qualification = await _service.GetQualificationById(id);

            if (qualification == null)
                return NotFound("Qualification not found.");

            return Ok(qualification);
        }

        [HttpPost("qualification")]
        public async Task<IActionResult> AddQualification(Qualification qualification)
        {
            var exists = (await _service.GetQualifications())
                .Any(x => x.QualificationName.Trim().ToLower()
                    == qualification.QualificationName.Trim().ToLower());

            if (exists)
                return Conflict("Qualification already exists.");

            var result = await _service.AddQualification(qualification);

            return Ok(result);
        }

        [HttpPut("qualification/{id}")]
        public async Task<IActionResult> UpdateQualification(int id, Qualification qualification)
        {
            var existing = await _service.GetQualificationById(id);

            if (existing == null)
                return NotFound("Qualification not found.");

            var duplicate = (await _service.GetQualifications())
                .Any(x => x.QualificationId != id &&
                         x.QualificationName.Trim().ToLower()
                            == qualification.QualificationName.Trim().ToLower());

            if (duplicate)
                return Conflict("Qualification already exists.");

            existing.QualificationName = qualification.QualificationName;
            existing.IsActive = qualification.IsActive;

            var result = await _service.UpdateQualification(existing);

            return Ok(result);
        }

        [HttpDelete("qualification/{id}")]
        public async Task<IActionResult> DeleteQualification(int id)
        {
            var existing = await _service.GetQualificationById(id);

            if (existing == null)
                return NotFound("Qualification not found.");

            await _service.DeleteQualification(id);

            return Ok("Qualification deleted successfully.");
        }


        // ==================== CERTIFICATION ====================

        [HttpGet("certifications")]
        public async Task<IActionResult> GetCertifications()
        {
            return Ok(await _service.GetCertifications());
        }

        [HttpGet("certification/{id}")]
        public async Task<IActionResult> GetCertificationById(int id)
        {
            var certification = await _service.GetCertificationById(id);

            if (certification == null)
                return NotFound("Certification not found.");

            return Ok(certification);
        }

        [HttpPost("certification")]
        public async Task<IActionResult> AddCertification(Certification certification)
        {
            var exists = (await _service.GetCertifications())
                .Any(x => x.CertificationName.Trim().ToLower()
                    == certification.CertificationName.Trim().ToLower());

            if (exists)
                return Conflict("Certification already exists.");

            var result = await _service.AddCertification(certification);

            return Ok(result);
        }

        [HttpPut("certification/{id}")]
        public async Task<IActionResult> UpdateCertification(int id, Certification certification)
        {
            var existing = await _service.GetCertificationById(id);

            if (existing == null)
                return NotFound("Certification not found.");

            var duplicate = (await _service.GetCertifications())
                .Any(x => x.CertificationId != id &&
                         x.CertificationName.Trim().ToLower()
                            == certification.CertificationName.Trim().ToLower());

            if (duplicate)
                return Conflict("Certification already exists.");

            existing.CertificationName = certification.CertificationName;
            existing.IsActive = certification.IsActive;

            var result = await _service.UpdateCertification(existing);

            return Ok(result);
        }

        [HttpDelete("certification/{id}")]
        public async Task<IActionResult> DeleteCertification(int id)
        {
            var existing = await _service.GetCertificationById(id);

            if (existing == null)
                return NotFound("Certification not found.");

            await _service.DeleteCertification(id);

            return Ok("Certification deleted successfully.");
        }


        // ==================== JOB TYPE ====================

        [HttpGet("job-types")]
        public async Task<IActionResult> GetJobTypes()
        {
            return Ok(await _service.GetJobTypes());
        }

        [HttpGet("job-type/{id}")]
        public async Task<IActionResult> GetJobTypeById(int id)
        {
            var jobType = await _service.GetJobTypeById(id);

            if (jobType == null)
                return NotFound("Job Type not found.");

            return Ok(jobType);
        }

        [HttpPost("job-type")]
        public async Task<IActionResult> AddJobType(JobType jobType)
        {
            var exists = (await _service.GetJobTypes())
                .Any(x => x.JobTypeName.Trim().ToLower()
                    == jobType.JobTypeName.Trim().ToLower());

            if (exists)
                return Conflict("Job Type already exists.");

            var result = await _service.AddJobType(jobType);

            return Ok(result);
        }

        [HttpPut("job-type/{id}")]
        public async Task<IActionResult> UpdateJobType(int id, JobType jobType)
        {
            var existing = await _service.GetJobTypeById(id);

            if (existing == null)
                return NotFound("Job Type not found.");

            var duplicate = (await _service.GetJobTypes())
                .Any(x => x.JobTypeId != id &&
                         x.JobTypeName.Trim().ToLower()
                            == jobType.JobTypeName.Trim().ToLower());

            if (duplicate)
                return Conflict("Job Type already exists.");

            existing.JobTypeName = jobType.JobTypeName;
            existing.IsActive = jobType.IsActive;

            var result = await _service.UpdateJobType(existing);

            return Ok(result);
        }

        [HttpDelete("job-type/{id}")]
        public async Task<IActionResult> DeleteJobType(int id)
        {
            var existing = await _service.GetJobTypeById(id);

            if (existing == null)
                return NotFound("Job Type not found.");

            await _service.DeleteJobType(id);

            return Ok("Job Type deleted successfully.");
        }


        // ==================== INTERVIEW TYPE ====================

        [HttpGet("interview-types")]
        public async Task<IActionResult> GetInterviewTypes()
        {
            return Ok(await _service.GetInterviewTypes());
        }

        [HttpGet("interview-type/{id}")]
        public async Task<IActionResult> GetInterviewTypeById(int id)
        {
            var interviewType = await _service.GetInterviewTypeById(id);

            if (interviewType == null)
                return NotFound("Interview Type not found.");

            return Ok(interviewType);
        }

        [HttpPost("interview-type")]
        public async Task<IActionResult> AddInterviewType(InterviewType interviewType)
        {
            var exists = (await _service.GetInterviewTypes())
                .Any(x => x.InterviewTypeName.Trim().ToLower()
                    == interviewType.InterviewTypeName.Trim().ToLower());

            if (exists)
                return Conflict("Interview Type already exists.");

            var result = await _service.AddInterviewType(interviewType);

            return Ok(result);
        }

        [HttpPut("interview-type/{id}")]
        public async Task<IActionResult> UpdateInterviewType(int id, InterviewType interviewType)
        {
            var existing = await _service.GetInterviewTypeById(id);

            if (existing == null)
                return NotFound("Interview Type not found.");

            var duplicate = (await _service.GetInterviewTypes())
                .Any(x => x.InterviewTypeId != id &&
                         x.InterviewTypeName.Trim().ToLower()
                            == interviewType.InterviewTypeName.Trim().ToLower());

            if (duplicate)
                return Conflict("Interview Type already exists.");

            existing.InterviewTypeName = interviewType.InterviewTypeName;
            existing.IsActive = interviewType.IsActive;

            var result = await _service.UpdateInterviewType(existing);

            return Ok(result);
        }

        [HttpDelete("interview-type/{id}")]
        public async Task<IActionResult> DeleteInterviewType(int id)
        {
            var existing = await _service.GetInterviewTypeById(id);

            if (existing == null)
                return NotFound("Interview Type not found.");

            await _service.DeleteInterviewType(id);

            return Ok("Interview Type deleted successfully.");
        }


        // ==================== INTERVIEW STATUS ====================

        [HttpGet("interview-statuses")]
        public async Task<IActionResult> GetInterviewStatuses()
        {
            return Ok(await _service.GetInterviewStatuses());
        }

        [HttpGet("interview-status/{id}")]
        public async Task<IActionResult> GetInterviewStatusById(int id)
        {
            var status = await _service.GetInterviewStatusById(id);

            if (status == null)
                return NotFound("Interview Status not found.");

            return Ok(status);
        }

        [HttpPost("interview-status")]
        public async Task<IActionResult> AddInterviewStatus(InterviewStatus status)
        {
            var exists = (await _service.GetInterviewStatuses())
                .Any(x => x.InterviewStatusName.Trim().ToLower()
                    == status.InterviewStatusName.Trim().ToLower());

            if (exists)
                return Conflict("Interview Status already exists.");

            var result = await _service.AddInterviewStatus(status);

            return Ok(result);
        }

        [HttpPut("interview-status/{id}")]
        public async Task<IActionResult> UpdateInterviewStatus(int id, InterviewStatus status)
        {
            var existing = await _service.GetInterviewStatusById(id);

            if (existing == null)
                return NotFound("Interview Status not found.");

            var duplicate = (await _service.GetInterviewStatuses())
                .Any(x => x.InterviewStatusId != id &&
                         x.InterviewStatusName.Trim().ToLower()
                            == status.InterviewStatusName.Trim().ToLower());

            if (duplicate)
                return Conflict("Interview Status already exists.");

            existing.InterviewStatusName = status.InterviewStatusName;
            existing.IsActive = status.IsActive;

            var result = await _service.UpdateInterviewStatus(existing);

            return Ok(result);
        }

        [HttpDelete("interview-status/{id}")]
        public async Task<IActionResult> DeleteInterviewStatus(int id)
        {
            var existing = await _service.GetInterviewStatusById(id);

            if (existing == null)
                return NotFound("Interview Status not found.");

            await _service.DeleteInterviewStatus(id);

            return Ok("Interview Status deleted successfully.");
        }


        // ==================== RECRUITMENT SOURCE ====================

        [HttpGet("recruitment-sources")]
        public async Task<IActionResult> GetRecruitmentSources()
        {
            return Ok(await _service.GetRecruitmentSources());
        }

        [HttpGet("recruitment-source/{id}")]
        public async Task<IActionResult> GetRecruitmentSourceById(int id)
        {
            var source = await _service.GetRecruitmentSourceById(id);

            if (source == null)
                return NotFound("Recruitment Source not found.");

            return Ok(source);
        }

        [HttpPost("recruitment-source")]
        public async Task<IActionResult> AddRecruitmentSource(RecruitmentSource source)
        {
            var exists = (await _service.GetRecruitmentSources())
                .Any(x => x.RecruitmentSourceName.Trim().ToLower()
                    == source.RecruitmentSourceName.Trim().ToLower());

            if (exists)
                return Conflict("Recruitment Source already exists.");

            var result = await _service.AddRecruitmentSource(source);

            return Ok(result);
        }

        [HttpPut("recruitment-source/{id}")]
        public async Task<IActionResult> UpdateRecruitmentSource(
            int id,
            RecruitmentSource source)
        {
            var existing = await _service.GetRecruitmentSourceById(id);

            if (existing == null)
                return NotFound("Recruitment Source not found.");

            var duplicate = (await _service.GetRecruitmentSources())
                .Any(x => x.RecruitmentSourceId != id &&
                         x.RecruitmentSourceName.Trim().ToLower()
                            == source.RecruitmentSourceName.Trim().ToLower());

            if (duplicate)
                return Conflict("Recruitment Source already exists.");

            existing.RecruitmentSourceName = source.RecruitmentSourceName;
            existing.IsActive = source.IsActive;

            var result = await _service.UpdateRecruitmentSource(existing);

            return Ok(result);
        }

        [HttpDelete("recruitment-source/{id}")]
        public async Task<IActionResult> DeleteRecruitmentSource(int id)
        {
            var existing = await _service.GetRecruitmentSourceById(id);

            if (existing == null)
                return NotFound("Recruitment Source not found.");

            await _service.DeleteRecruitmentSource(id);

            return Ok("Recruitment Source deleted successfully.");
        }
    }
}