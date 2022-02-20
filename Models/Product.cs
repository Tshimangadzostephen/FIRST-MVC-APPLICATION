using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW3.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product()
        {
            this.ID = Guid.NewGuid();
        }

        public Product(string n, string d, double p)
        {
            this.ID = Guid.NewGuid();
            this.Name = n;
            this.Description = d;
            this.Price = p;
        }

        public double GetTotal()
        {
            return this.Quantity * this.Price;
        }

        public Product Clone()
        {
            return new Product { 
                ID = this.ID,
                Name = this.Name,
                Description = this.Description,
                Quantity = 0,
                Price = this.Price,
            };
        }

        public void Copy(Product product)
        {
            this.Name = product.Name;
            this.Description = product.Description;
            this.Price = product.Price;
        }
    }
}