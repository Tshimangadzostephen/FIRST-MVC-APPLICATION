using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW3.Repository;
using HW3.Models;

namespace HW3.Controllers
{
    public class AdminController : Controller
    {
        // Table view of ProductList
        public ActionResult Index()
        {
            return View(ProductList.GetProducts());
        }

        // Add to ProductList Repo
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            ProductList.AddProduct(product);

            return RedirectToAction("Index");
        }

        // Edit item in ProductList
        [HttpGet]
        public ActionResult EditProduct(Guid id)
        {
            return View(ProductList.GetProduct(id));
        }

        [HttpPost]
        public ActionResult EditProduct(Product product)
        {
            ProductList.EditProduct(product);

            return RedirectToAction("Index");
        }

        // Delete item from ProductList
        public ActionResult DeleteProduct(Guid id)
        {
            ProductList.RemoveProduct(id);

            return RedirectToAction("Index");
        }
    }
}