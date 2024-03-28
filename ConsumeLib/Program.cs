using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLinq;

namespace ConsumeLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Product> products = Product.GetAllProducts();

            //IEnumerable<Product> selectedProduct = from p in products
            //                                        where p.Price >=  400
            //                                        select p;
            IList<Product> selectedProduct = products.Where(p => p.Price >= 150).ToList();
            foreach (Product p in selectedProduct)
            {
                Console.WriteLine(p.Name + " " + p.Price + " " + " " + p.Category);
            }

        }
    }
}
