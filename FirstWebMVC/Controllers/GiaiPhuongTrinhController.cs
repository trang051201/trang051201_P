using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class GiaiPhuongTrinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
//Quach Kieu Trang - 2021050654
//Giai phuong trinh bac hai
        [HttpPost]

        public IActionResult Index(double a, double b, double c)
        {
            
            double denta = (b*b - 4*a*c);

            if ( denta < 0)
            {
                ViewBag.ThongBao = "Phuong Trinh Vo Nghiem";
            }else if( denta == 0 )
            {
                double nghiemkep = -b / 2*a;
                ViewBag.ThongBao = $"Phuong Trinh co nghiem kep = {nghiemkep}";
            }else
            {
                double nghiem1 = (-b + Math.Sqrt(denta)) / 2*a;
                double nghiem2 = (-b - Math.Sqrt(denta)) / 2*a;

                ViewBag.ThongBao = $"Phuong trinh co 2 nghiem: Nghiem 1 = {nghiem1} | Nghiem 2 = {nghiem2}";
            }
            
//Quach Kieu Trang - 2021050654
            return View();
        }

            
    }
}
