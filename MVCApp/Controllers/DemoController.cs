using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //host/Demo/ABC
        public IActionResult ABC()
        {
            ViewBag.A = "HCMUE - FIT";
            ViewData["B"] = "2020 - 2021";
            return View("XYZ");
        }
    }
}