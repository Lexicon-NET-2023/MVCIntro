using System.ComponentModel.DataAnnotations;

namespace MVCIntro.Models
{
//#nullable disable
    public class Employee
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }
    }
}
