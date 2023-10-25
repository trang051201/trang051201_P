using System.ComponentModel.DataAnnotations;
namespace DEMOMVC.Models
{
//Quách Kiều Trang - 2021050654
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

//Quách Kiểu Trang - 2021050654
