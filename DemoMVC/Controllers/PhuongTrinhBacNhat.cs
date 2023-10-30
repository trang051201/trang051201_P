using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class PhuongTrinhBacNhatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
//Quách kiều trang - 2021050654. 
//Giai phuong trinh bac nhat
        [HttpPost]
        public IActionResult Index(double a, double b)
        {
            if (a == 0)
            {
            if (b==0)
                {
                      ViewBag.ThongBao = "Phuong trinh co vo so nghiem";
                }else 
                {
                    ViewBag.ThongBao = "Phuong trinh vo nghiem";
                }
//Quách kiều trang - 2021050654
            }else
            {
                double nghiem = -b / a;
               ViewBag.ThongBao =  $"Nghiem cua phuong trinh la x = {nghiem}";
            } 

//Quách kiều trang - 2021050654
            return View();
        }
    }
}
