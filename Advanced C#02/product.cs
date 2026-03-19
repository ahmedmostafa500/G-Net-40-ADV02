using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_02
{
    public class Product
    {
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> condition)
        {
            List<Product> Result = new List<Product>();
            foreach (Product product in products)
            {
                if (condition(product))
                {
                    Result.Add(product);

                }
            }
            return Result;
        }
        public static void PrintProducts(string title, List<Product> products)
        {
            Console.WriteLine($"\n--- {title} ---");
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }
        }
        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (var p in products)
            {
                action(p);
            }
        }

        public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        {
            List<string> result = new List<string>();

            foreach (var p in products)
            {
                result.Add(transform(p));
            }

            return result;
        }



        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
