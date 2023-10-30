
using Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
using DEMOMVC.Models;


//Quach Kieu Trang - 2021050654
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
    }

    }
//Quach Kieu Trang - 2021050654
