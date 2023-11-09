using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
//Quách Kiều Trang 2021050654
    public class EmployeeController : Controller
    {
         public IActionResult Index()
            {
                return View();
//Quách Kiều Trang 2021050654
            }
            [HttpPost]
         public IActionResult Index(Employee emp)
            {
//Quách Kiều Trang 2021050654
                string str = emp.FullName + "_" + emp.EmployeeID + "_" +"_"+ emp.Address; 
                ViewBag.KetQua = str;
                return View();
//Quách Kiều Trang 2021050654
            }
    }
}