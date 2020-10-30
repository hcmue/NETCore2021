using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLayout.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoLayout.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult GetCategory()
        {
            var data = new List<Category>()
            {
                new Category(1, "Ti vi"),
                new Category(2, "Điện thoại"),
                new Category(3, "Tủ lạnh"),
                new Category(4, "Điều hòa"),
            };

            return PartialView("GetCategory", data);
        }
    }
}