using System.ComponentModel.DataAnnotations;

namespace EmployeesystemAdo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string? Name { get; set; }

        public String? Jobrole { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        public decimal Salary { get; set; }
    }
}
