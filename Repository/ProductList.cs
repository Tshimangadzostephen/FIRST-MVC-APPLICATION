using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW3.Models;

namespace HW3.Repository
{
    public class ProductList
    {
        private static List<Product> Products = new List<Product> { 
            new Product("Nike", "Shoes", 800),
            new Product("Pizza", "Food", 90),
            new Product("Car", "Toy", 40),
            new Product("Jelly Babies", "Candy", 24),
            new Product("Dell", "Laptop", 7500),
        };

        public static Product GetProduct(Guid id)
        {
            foreach (Product product in Products)
            {
                if (product.ID.Equals(id))
                {
                    return product.Clone();
                }
            }

            return null;
        }

        public static Product Product(Guid id)
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

        public static List<Product> GetProducts()
        {
            return Products;
        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static void RemoveProduct(Guid id)
        {
            Products.Remove(Product(id));
            Cart.RemoveProduct(id);
        }

        public static void EditProduct(Product product)
        {
            Product old = Product(product.ID);
            old.Copy(product);
        }
    }
}