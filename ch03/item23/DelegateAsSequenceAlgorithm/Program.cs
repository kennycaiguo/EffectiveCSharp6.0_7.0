using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsSequenceAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] xValues = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            double[] yValues = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            List<Point> values;

            Console.WriteLine("use Example.Zip<>:");
            values = new List<Point>(
                Example.Zip(xValues, yValues, (x, y) => new Point(x, y)));
            values.ForEach((pt) => Console.WriteLine(pt.ToString()));

            Console.WriteLine("use System.Linq.Enumerable.Zip<>:");
            values = new List<Point>(
                System.Linq.Enumerable.Zip(xValues, yValues, (x, y) => new Point(x, y)));
            values.ForEach((pt) => Console.WriteLine(pt.ToString()));

        }
    }
}
