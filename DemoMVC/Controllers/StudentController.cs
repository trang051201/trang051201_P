using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;

namespace DemoMVC.Controllers
{
//Quách kiều trang - 2021050654 -student-controller
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
//Quách kiều trang - 2021050654
            }
    }
}