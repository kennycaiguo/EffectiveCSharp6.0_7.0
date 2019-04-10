using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFilteredData
{
    class Program
    {
        static IEnumerable<Product> MakeProducts()
        {
            var products = new List<Product>();
            for (int i = 0; i < 1000000; i++)
            {
                int units;
                if ((i % 123456) == 0) units = (i % 100) + 100;
                else units = i % 100;

                Product p = new Product { Name = $"product#{i}", UnitsInStock = units };
                products.Add(p);
            }
            return products;
        }

        static void Main(string[] args)
        {
            var products = MakeProducts();

            var sortedProductsSlow =
                from p in products
                orderby p.UnitsInStock descending
                where p.UnitsInStock > 100
                select p;

            var sortedProductsFast =
                from p in products
                where p.UnitsInStock > 100
                orderby p.UnitsInStock descending
                select p;

            var sw = new System.Diagnostics.Stopwatch();

            sw.Start();
            foreach (var p in sortedProductsSlow)
                Console.WriteLine(p);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"sorted products slow: {ts}");

            sw.Restart();
            foreach (var p in sortedProductsFast)
                Console.WriteLine(p);
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine($"sorted products fast: {ts}");
        }
    }
}
