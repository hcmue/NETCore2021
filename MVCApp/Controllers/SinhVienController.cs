using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class SinhVienController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SinhVien sv, string Khoa)
        {
            //return Json(sv);
            return Json(new { 
                Khoa = Khoa,
                SinhVien = sv
            });
        }
    }
}