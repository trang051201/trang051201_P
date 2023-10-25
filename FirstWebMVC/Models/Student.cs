using System.ComponentModel.DataAnnotations;
namespace DEMOMVC.Models
{
//Nghiem Thi Van Anh - 2021050078
    public class Student
    {
       [Required(ErrorMessage = "Vui long nhap Student id")]
        public string StudentID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public int Age { get; set; }

    }
}

//Nghiem Thi Van Anh - 2021050078