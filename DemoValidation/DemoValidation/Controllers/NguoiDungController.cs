using Microsoft.AspNetCore.Mvc;

namespace DemoValidation.Controllers
{
    public class NguoiDungController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult XuLyDangKy()
        {
            return View();
        }


    }
}