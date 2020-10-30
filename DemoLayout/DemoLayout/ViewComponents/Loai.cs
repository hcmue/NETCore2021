using DemoLayout.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLayout.ViewComponents
{
    public class Loai : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = new List<Category>()
            {
                new Category(1, "Ti vi"),
                new Category(2, "Điện thoại"),
                new Category(3, "Tủ lạnh"),
                new Category(4, "Điều hòa"),
            };

            return View(data);
        }
    }
}
