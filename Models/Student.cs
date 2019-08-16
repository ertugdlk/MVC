using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Missing name information")]
        public string name { get; set; }

        [Required(ErrorMessage = "Missing email information")]
        [EmailAddress(ErrorMessage ="Your email format wrong")]
        public string email{ get; set; }


        [Required(ErrorMessage = "Missing phone information")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Missing confirmation information")]
        public bool? confirm  { get; set; }
    }
}