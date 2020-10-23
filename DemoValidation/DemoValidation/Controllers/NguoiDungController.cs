using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

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
            #region Sinh mã bảo mật
            var random = new Random();
            var securityText = random.Next(10000, 100000);
            HttpContext.Session.SetInt32("MaBaoMat", securityText);
            #endregion

            return View();
        }

        public string KiemTraMaBaoMat(int MaBaoMat)
        {
            return HttpContext.Session.GetInt32("MaBaoMat") == MaBaoMat ? "true" : "false";
        }


        [HttpPost]
        public IActionResult XuLyDangKy()
        {
            return View();
        }


    }
}