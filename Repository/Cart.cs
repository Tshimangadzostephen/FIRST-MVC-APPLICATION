using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW3.Models;

namespace HW3.Repository
{
    public static class Cart
    {
        private readonly static List<Product> Products = new List<Product>();

        public static Product GetProduct(Guid id)
        {
            foreach (Product product in Products)
            {
                if (product.ID.Equals(id))
                {
                    return product;
                }
            }

            return null;
        }

        public static void AddProduct(Product product)
        {
            Product prod = GetProduct(product.ID);
            if (prod == null)
            {
                product.Quantity = 1;
                Products.Add(product);
            }
            else
            {
                prod.Quantity += 1;
            }
            
        }

        public static void IncQuantity(Guid id)
        {
            GetProduct(id).Quantity += 1;
        }

        public static void DecQuantity(Guid id)
        {
            if (GetProduct(id).Quantity == 1)
                RemoveProduct(id);
            else
                GetProduct(id).Quantity -= 1;
        }

        public static void RemoveProduct(Guid id)
        {
            Products.Remove(GetProduct(id));
        }

        public static List<Product> GetCart()
        {
            return Products;
        }
    }
}