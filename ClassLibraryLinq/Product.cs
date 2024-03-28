using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLinq
{
    public  class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        private static List<Product> products;
        public static List<Product> GetAllProducts()
        {
            products = new List<Product>()
            {
                new Product() { Name= "Ipad", Price=400, Category="Multimedia" },
                new Product() { Name= "PowerSupply", Price=80, Category="Test"  },
                new Product() { Name= "Laptop", Price=650, Category="Multimedia"  },
                new Product() { Name= "Printer", Price=150, Category="Electronics"  },
                new Product() { Name= "TV", Price=800, Category="Multimedia"  },
                new Product() { Name= "Ipod", Price=150, Category="Test"  },
                new Product() { Name= "Scanner", Price=1050, Category="Electronics"  },
            };
            return products;
        }
    }
}
