using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(double SoHang1, double SoHang2, string PhepToan)
        {
            var kq = 0.0;
            switch (PhepToan)
            {
                case "+": kq = SoHang1 + SoHang2; break;
                case ":": kq = SoHang1 / SoHang2; break;
                case "^": kq = Math.Pow(SoHang1, SoHang2); break;
            }
            ViewBag.SoHang1 = SoHang1;
            ViewBag.SoHang2 = SoHang2;
            ViewBag.PhepToan = PhepToan;
            ViewBag.KetQua = kq;

            return View("Index");
            //return Content($"{SoHang1} {PhepToan} {SoHang2} = {kq}");
        }
    }
}