using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCreateSequence
{
    class Program
    {
        static void TestCreateIntSequence()
        {
            Console.WriteLine("TestCreateIntSequence():");
            foreach (var i in Util.CreateSequence(20, 0, 5))
                Console.Write($"{i} ");
            Console.WriteLine();

        }

        static void TestCreateGenericSequence()
        {
            Console.WriteLine("TestCreateGenericSequence():");

            var startAt = 0;
            var nextValue = 5;
            foreach (var i in Util.CreateSequence(20, () => startAt += nextValue))
                Console.Write($"{i} ");
            Console.WriteLine();

        }

        static void TestCreateGenericSequenceImproved()
        {
            Console.WriteLine("TestCreateGenericSequenceImproved():");

            var startAt = 0;
            var nextValue = 5;
            foreach (var i in Util.CreateSequence(20, (i) => startAt + i * nextValue))
                Console.Write($"{i} ");
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            TestCreateIntSequence();
            TestCreateGenericSequence();
            TestCreateGenericSequenceImproved();
        }
    }
}
