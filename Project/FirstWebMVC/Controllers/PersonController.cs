using FirstWebMVC.Models.Person;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers;
public class PersonController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string strResult = "Hello" + ps.PersonID + "-" + ps.Fullname;
        ViewBag.thongBao = strResult;
        return View();
    }

}