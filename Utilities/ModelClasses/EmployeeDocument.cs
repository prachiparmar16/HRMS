using System;
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.ModelClasses
{
    public class EmployeeDocument
    {
        [Key]
        public int DocumentId { get; set; }

        public int EmployeeId { get; set; }

        public string DocumentType { get; set; }

        public string DocumentName { get; set; }

        public string DocumentPath { get; set; }

        public DateTime UploadedDate { get; set; }

        public string Status { get; set; }
    }
}