using System.ComponentModel.DataAnnotations.Schema;

namespace Demo123.Models.Domain
{
    [Table("Employee")]
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBirth { get; set;}
        public string Department { get; set; }
    }
}
