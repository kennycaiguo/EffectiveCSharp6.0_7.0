using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericClassGeneicMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var dList = new List<double> { 1.2, 3.4, 5.6 };
            var sList = new List<string> { "abc", "xyz", "$%&" };
            var builder = new CommaSeparatedListBuilder();
            builder.Add(dList);
            builder.Add(sList);
            var result = builder.ToString();
            Console.WriteLine(result);
        }
    }
}
