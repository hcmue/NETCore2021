using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01_ProductCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab01_ProductCRUD.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> Products = new List<Product>();

        public IActionResult Index()
        {
            return View(Products);
        }

        #region Create New Product
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            var _product = Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (_product == null)
            {
                //Add to list
                Products.Add(product);
            }                

            //Redirect to action Index to show list
            return RedirectToAction("Index");
        }
        #endregion

        #region Edit Product
        public IActionResult Edit(int id)
        {
            var product = Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                return View(product);
            }

            //return RedirectToAction(actionName: "Index", controllerName: "Product");
            return RedirectToAction("Index", "Product");
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var _product = Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (_product != null)
            {
                //Update data
                _product.ProductName = product.ProductName;
                _product.UnitPrice = product.UnitPrice;
                _product.Quantity = product.Quantity;
            }

            return RedirectToAction("Index");
        }
        #endregion

        public IActionResult Delete(int id)
        {
            var _product = Products.FirstOrDefault(p => p.ProductId == id);
            if (_product != null)
            {
                //Remove
                Products.Remove(_product);
            }

            return RedirectToAction("Index");
        }
    }
}