using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Persons")]
    //Quách kiều trang-2021050654
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
  //Quách kiều trang-2021050654