using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAlgorithm
{
    class Program
    {
        static void TestIntSequence()
        {
            Console.WriteLine("TestIntSequence():");
            IEnumerable<int> intSequence = Enumerable.Range(1, 5);

            Console.WriteLine("IntSequence:");
            var reverseIntSequence = new ReverseEnumerable<int>(intSequence);
            foreach (var item in reverseIntSequence)
                Console.WriteLine(item);

            Console.WriteLine("Sequence (cast IEnumerable<int> as IEnumerable):");
            IEnumerable reverseSequence = new ReverseEnumerable<int>(intSequence) as IEnumerable;
            foreach (var item in reverseSequence)
                Console.WriteLine(item);
        }

        static void TestIntList()
        {
            Console.WriteLine("TestIntList():");
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("IntList:");
            var reverseSequence = new ReverseEnumerable<int>(list);
            foreach (var item in reverseSequence)
                Console.WriteLine(item);

            Console.WriteLine("IntSequence (cast List<int> as IEnumerable<int>):");
            IEnumerable<int> reverseSequence2 = new ReverseEnumerable<int>(list) as IEnumerable<int>;
            foreach (var item in reverseSequence2)
                Console.WriteLine(item);
        }

        static void Main(string[] args)
        {
            TestIntSequence();
            TestIntList();
        }
    }
}
