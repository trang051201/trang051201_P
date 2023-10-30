using System.Reflection.Metadata.Ecma335;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{ 
     public class PersonController : Controller
    {
         public IActionResult Index()
            {
                return View();
            }
        [HttpPost]
        public IActionResult Index(Person prs)
        {
            string str = prs.PersonID +"_" + prs.FullName;
            ViewBag.thongBao = str;
            return View();
        }
 //Quách kiều trang  - MSV : 2021050654      
    }
}