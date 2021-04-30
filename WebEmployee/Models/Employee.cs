using System.ComponentModel.DataAnnotations;

namespace WebEmployee.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required, MaxLength(80, ErrorMessage = "Name cannot exceed 80 characters")]
        public string Name { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid format email")]
        public string Email { get; set; }

        public Department? Department { get; set; }
    }
}
