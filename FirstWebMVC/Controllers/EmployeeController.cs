using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
//Nghiem Thi Van Anh -2021050078
    public class EmployeeController : Controller
    {
         public IActionResult Index()
            {
                return View();
//Nghiem Thi Van Anh -2021050078
            }
            [HttpPost]
         public IActionResult Index(Employee emp)
            {

                int TinhLuong = (emp.LuongCB) *  (emp.HeSoLuong) +emp.PhuCap;
                string str1 = "FullName: " + " "+ emp.FullName + " " + "Luong: " + TinhLuong + "VND";
                ViewBag.KetQuaTinhLuong = str1;
                return View();
//Nghiem Thi Van Anh -2021050078
            }
    }
}