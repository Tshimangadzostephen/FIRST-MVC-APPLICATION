using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW3.Repository;
using HW3.Models;

namespace HW3.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            return View(ProductList.GetProducts());
        }

        public ActionResult AddToCart(Guid id)
        {
            Product product = ProductList.GetProduct(id);
            Cart.AddProduct(product);

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(Guid id)
        {
            Cart.RemoveProduct(id);

            return RedirectToAction("ViewCart");
        }

        public ActionResult ViewCart()
        {
            return View(Cart.GetCart());
        }

        public ActionResult IncProduct(Guid id)
        {
            Cart.IncQuantity(id);

            return RedirectToAction("ViewCart");
        }

        public ActionResult DecProduct(Guid id)
        {
            Cart.DecQuantity(id);

            return RedirectToAction("ViewCart");
        }
    }
}