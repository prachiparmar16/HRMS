using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class LeavePolicy
    {
        [Key]
        public int LeavePolicyId { get; set; }

        [Required(ErrorMessage = "Leave policy name is required.")]
        [MaxLength(100, ErrorMessage = "Leave policy name cannot exceed 100 characters.")]
        public string LeavePolicyName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Leave type is required.")]
        public int LeaveTypeId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Total days must be greater than 0.")]
        public int TotalDays { get; set; }

        public bool IsActive { get; set; } = true;

        public LeaveType LeaveType { get; set; }
    }
}