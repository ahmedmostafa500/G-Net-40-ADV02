namespace Advanced_C_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region assigment
            List<Product> catalog = new List<Product>()
{
    new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
    new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
    new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
    new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
    new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
    new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
    new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
    new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
    new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 }
            };
            var electronics = Product.SearchProducts(catalog, p => p.Category == "Electronics");

            var under50 = Product.SearchProducts(catalog, p => p.Price < 50);

            var inStock = Product.SearchProducts(catalog, p => p.Stock > 0);

            var clothingUnder100 = Product.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);

            Product.PrintProducts("Electronics", electronics);
            Product.PrintProducts("under50", under50);
            Product.PrintProducts("inStock", inStock);
            Product.PrintProducts("clothingUnder100", clothingUnder100);

            Console.WriteLine("--------------------------------");

            Console.WriteLine("--- Short Report ---");
            Product.PrintReport(catalog, p =>
        Console.WriteLine($"{p.Name} - ${p.Price}")
    );

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--- Detailed Report  ---");
            Product.PrintReport(catalog, p =>
       Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}")
   );

            Console.WriteLine("--------------------------------");
            var summary = Product.TransformProducts(catalog, p =>
            $"{p.Name} (${p.Price})"
            );
            Console.WriteLine("--- Summary List ---");

            foreach (var item in summary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------");
            var labels = Product.TransformProducts(catalog, p =>
        p.Price > 100 ? "Expensive!" : "Affordable"
            );

            for (int i = 0; i < catalog.Count; i++)
            {
                Console.WriteLine($"{catalog[i].Name}: {labels[i]}");
            }

            #endregion
        }
    }
}
