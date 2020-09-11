using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HangHoaController : Controller
    {
        public static List<HangHoa> dsHangHoa { get; set; } = new List<HangHoa>();
        public IActionResult Index()
        {
            return View(dsHangHoa);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HangHoa hh)
        {
            dsHangHoa.Add(hh);
            return RedirectToAction("Index");
        }
    }
}