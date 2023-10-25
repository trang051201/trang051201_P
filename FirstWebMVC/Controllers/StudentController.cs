using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;

namespace DemoMVC.Controllers
{
//Nghiem Thi Van Anh -2021050078
    public class StudentController : Controller
    {
         public IActionResult Index()
            {
                return View();

            }
            [HttpPost]
         public IActionResult Index(Student std)
            {
                string str = "Hello " + std.StudentID + "-" + std.FullName + "-" + std.address + "-" + std.Age;
                ViewBag.thongBao = str;
                return View();
//Nghiem Thi Van Anh -2021050078
            }
    }
}