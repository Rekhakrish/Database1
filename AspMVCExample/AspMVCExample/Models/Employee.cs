using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspMVCExample.Models
{
    public class Employee
    {
        [Display(Name = "EmpID")]
        [Required(ErrorMessage = "EmployeeID Mandate")]
        public int employeeID { get; set; }
        public string employeeName { get; set; }
        public int employeeAge { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double salary { get; set; }
        [Required(ErrorMessage = "Enter a Proper mailID")]
        [DataType(DataType.EmailAddress)]
        public string empMailID { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string passwrd { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("passwrd")]
        public string cmpPass { get; set; }

    }
   
}
