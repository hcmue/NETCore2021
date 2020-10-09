using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class DemoController : Controller
    {
        #region Upload file
        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessSingleFile(IFormFile MyFile)
        {
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", MyFile.FileName);
            using(var file = new FileStream(fullPath, FileMode.Create))
            {
                MyFile.CopyTo(file);
            }
            return RedirectToAction("Upload");
        }

        [HttpPost]
        public IActionResult ProcessMultipleFile(List<IFormFile> MyFiles)
        {
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "MyData");
            foreach(var myFile in MyFiles)
            {
                var fullPath = Path.Combine(folder, myFile.FileName);
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    myFile.CopyTo(file);
                }
            }
            
            return RedirectToAction("Upload");
        }
        #endregion

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