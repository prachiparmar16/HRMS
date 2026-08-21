using System.ComponentModel.DataAnnotations;

namespace HRMS_API.Model
{
    public class StudentD
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public long Contact { get; set; }
    }
}
