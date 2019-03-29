using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRemoveAll
{
    class Program
    {
        static void FuncArgVersion()
        {
            Console.WriteLine("FuncArgVersion():");

            var ints = new List<int>
                { 0, 11, 22, 32, 44, 55, 66, 77, 88, 99, 111, 222, 333, 444, 555, 666, 777, 888, 999 };
            ints.RemoveAll(i => i < 100);
            foreach (var i in ints)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        public class MyPredicate : IPredicate<int>
        {
            public bool Match(int target) => target < 100;
        }

        static void InterfaceVersion()
        {
            Console.WriteLine("InterfaceVersion():");

            var ints = new List<int>
                { 0, 11, 22, 32, 44, 55, 66, 77, 88, 99, 111, 222, 333, 444, 555, 666, 777, 888, 999 };
            var myInts = new MyList<int>(ints);
            var myPred = new MyPredicate();
            myInts.RemoveAll(myPred);
            foreach (var i in myInts)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            FuncArgVersion();
            InterfaceVersion();
        }
    }
}
