using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2019.02.23 add
using System.Collections;

namespace EnumerableCast
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable collection = new List<int>()
                { 1,2,3,4,5,6,7,8,9,10 };

            var small = from int item in collection
                        where item < 5
                        select item;
            var small2 = collection.Cast<int>().Where(item => item < 5).Select(n => n);
            var small3 = collection.Cast<double>().Where(item => item < 5).Select(n => n);

            foreach (var i in small) Console.WriteLine(i);
            foreach (var i in small2) Console.WriteLine(i);
            try
            {
                foreach (var i in small3) Console.WriteLine(i);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Enumerable.Cast<double> fails: " + e);
            }
        }
    }
}
