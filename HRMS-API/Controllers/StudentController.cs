using Microsoft.AspNetCore.Mvc;
using HRMS_API.Model;

namespace HRMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("GetAllStudent")]
        public IActionResult GetAllStudent()
        {
            List<StudentD> studentList = new List<StudentD>
            {
                new StudentD { Id = 1, Name = "Prachi", Department = "CSE", Contact = 9876543210 },
                new StudentD { Id = 2, Name = "Rahul", Department = "IT", Contact = 9876543211 },
                new StudentD { Id = 3, Name = "Amit", Department = "ECE", Contact = 9876543212 },
                new StudentD { Id = 4, Name = "Neha", Department = "ME", Contact = 9876543213 }
            };

            return Ok(studentList);
        }

        [HttpGet("GetStudentById")]
        public IActionResult GetStudentById(int id)
        {
            List<StudentD> studentList = new List<StudentD>
            {
                new StudentD { Id = 1, Name = "Prachi", Department = "CSE", Contact = 9876543210 },
                new StudentD { Id = 2, Name = "Rahul", Department = "IT", Contact = 9876543211 },
                new StudentD { Id = 3, Name = "Amit", Department = "ECE", Contact = 9876543212 },
                new StudentD { Id = 4, Name = "Neha", Department = "ME", Contact = 9876543213 }
            };

            studentList = studentList.Where(s => s.Id == id).ToList();

            if (studentList.Count > 0)
            {
                return Ok(studentList);
            }

            return NotFound($"Student with Id {id} not found");
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent(StudentD student)
        {
            return Ok("Student Added Successfully");
        }

        [HttpDelete("DeleteStudent")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok($"Student with Id {id} Deleted Successfully");
        }
    }
}