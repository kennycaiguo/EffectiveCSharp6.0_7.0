using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var sophia = new Customer("Sophia");
            var sophia_dash = new Customer("Sophia");
            var seiji = new Customer("Seiji");
            bool result;

            result = sophia < seiji;
            Console.WriteLine($"shopia < seiji: {result}");
            result = sophia <= seiji;
            Console.WriteLine($"shopia <= seiji: {result}");
            result = sophia >= seiji;
            Console.WriteLine($"shopia >= seiji: {result}");
            result = sophia > seiji;
            Console.WriteLine($"shopia > seiji: {result}");

            result = sophia < sophia_dash;
            Console.WriteLine($"sophia < sophia_dash: {result}");
            result = sophia <= sophia_dash;
            Console.WriteLine($"sophia <= sophia_dash: {result}");
            result = sophia >= sophia_dash;
            Console.WriteLine($"sophia >= sophia_dash: {result}");
            result = sophia > sophia_dash;
            Console.WriteLine($"sophia > sophia_dash: {result}");

        }
    }
}
