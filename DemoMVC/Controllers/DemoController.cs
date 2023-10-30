using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        //khai bao cac phuong thuc
         public IActionResult Index()
            {
                return View();

            }
            [HttpPost]
         public IActionResult Index(string fuName, string Email)
            {
                string strResult = "Hello" + fuName + "-" + "email" + Email;
                ViewBag.Chay = strResult;
                return View();

            }

    }
}