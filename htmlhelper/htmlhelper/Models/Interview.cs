using System.ComponentModel.DataAnnotations;

namespace htmlhelper.Models
{
    public class Interview
    {
        [Required(ErrorMessage = "Please enter student name.")]
        public int name; 
        public DateTime dob; 
        public string Gender;
        public bool jobrole;
        public string address;
        public string District;
        public int pincode;

    }
    public enum Gender
    {
        Male,
        Femlae
    }
}
