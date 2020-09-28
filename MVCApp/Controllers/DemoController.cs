using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult DemoSync()
        {
            var demo = new Demo();
            var dongHo = new Stopwatch();
            dongHo.Start();
            demo.FunctionA();
            demo.FunctionB();
            demo.FunctionC();
            dongHo.Stop();

            return Content($"Chạy hết {dongHo.ElapsedMilliseconds} ms");
        }

        [Route("/DemoAsync")]
        public async Task<IActionResult> DemoAsync()
        {
            var demo = new Demo();
            var dongHo = new Stopwatch();
            dongHo.Start();
            var a = demo.FunctionAAsync();
            var b = demo.FunctionBAsync();
            var c = demo.FunctionCAsync();
            await a; await b; await c;
            dongHo.Stop();

            return Content($"Chạy hết {dongHo.ElapsedMilliseconds} ms");
        }

        //URL friendly
        [Route("/dien-thoai/{tenDienThoai}")]
        public string ABCDEF(string tenDienThoai)
        {
            return $"Điện thoại {tenDienThoai}";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TranferData()
        {
            ViewData["Truong Hoc"] = "HCMUE";
            ViewData["Lop"] = "COMP1064";
            ViewBag.NamHoc = 2020;

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