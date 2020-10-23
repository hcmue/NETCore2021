using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoValidation.Controllers
{
    public class DemoController : Controller
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
        public IActionResult DangKy(SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                //Xử lý
            }
            else
            {
                ModelState.AddModelError("loi", "Chưa valid");
            }
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }

        public IActionResult KiemTraMaNhanVien(int EmployeeNo)
        {
            var employeeNos = new List<int>();
            employeeNos.Add(111);
            employeeNos.Add(777);
            employeeNos.Add(357);

            if(employeeNos.Contains(EmployeeNo))
            {
                return Json(false);
            }
            return Json(true);
        }
    }
}