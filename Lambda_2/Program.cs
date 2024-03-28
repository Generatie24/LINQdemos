using ClassLibraryLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lambda_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IEnumerable<Product> getAll = Product.GetAllProducts();

            #region Take
            //IEnumerable<Product> mostExpensive3 = getAll.OrderByDescending(p => p.Price).Take(3);
            //foreach (Product p in mostExpensive3)
            //{
            //    Console.WriteLine($"{p.Name} {p.Price}");
            //}
            #endregion

            #region Skip
            //IEnumerable<Product> skipmostExpensive = 
            //    getAll.OrderByDescending(p => p.Price).Skip(1);
            //foreach (Product p in skipmostExpensive)
            //{
            //    Console.WriteLine($"{p.Name} {p.Price}");
            //}
            #endregion

            #region OrderByThanBy
            //IEnumerable<Product> orderByCategoryThanPrice =
            //    getAll.OrderBy(p => p.Name).ThenByDescending(p => p.Price).ThenBy(p => p.Category);

            //foreach (Product p in orderByCategoryThanPrice)
            //{
            //    Console.WriteLine($"{p.Name} {p.Category} {p.Price.ToString("c")} ");
            //}
            #endregion

            #region GroupBy

            //Console.WriteLine("--------------Group by------------------------");
            //foreach (var groups in getAll
            //   .GroupBy(c => c.Category)
            //   .Select(group => new { Category = group.Key, Count = group.Count() })
            //   .OrderBy(c => c.Category))
            //{
            //    Console.WriteLine($"{groups.Category} {groups.Count}");
            //}
            #endregion

            #region First
            Product product = getAll.FirstOrDefault(p => p.Name.ToLower() == "LaaPtop".ToLower()); // program crashes if product not found even if we test for null
            if (product == null)
            {
                Console.WriteLine("No product found");
            }
            else
            {
                Console.WriteLine("Product found : " + product.Name + " " + product.Price);
            }

            #endregion

            var counteletronic = getAll.Count(p => p.Category == "Electronics");
            Console.WriteLine(counteletronic);

        }
    }
}
