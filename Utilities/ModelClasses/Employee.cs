using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Text;

namespace HRMS.Models.ModelClasses
        {
            public class Employee
            {
                [Key]
                public int EmployeeId { get; set; }

                public string FirstName { get; set; }

                public string MiddleName { get; set; }

                public string LastName { get; set; }

                public string Gender { get; set; }

                public DateOnly DateOfBirth { get; set; }

                public string PersonalEmail { get; set; }

                public string Contact { get; set; }

                public string CompanyEmail { get; set; }

                public int DepartmentId { get; set; }

                public int DesignationId { get; set; }

                public int GradeId { get; set; }

                public DateOnly DateOfJoining { get; set; }

                public string EmploymentType { get; set; }

                public string EmployeeStatus { get; set; }

                public bool IsActive { get; set; }
            }
        }
