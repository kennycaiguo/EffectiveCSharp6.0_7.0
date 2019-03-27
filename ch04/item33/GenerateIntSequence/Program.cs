using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateIntSequence
{
    class Program
    {
        static IEnumerable<int> CreateSequence(int numberOfElements,
            int startAt, int stepBy)
        {
            for (int i = 0; i < numberOfElements; i++)
                yield return startAt + i * stepBy;
        }

        static void TestBindingList()
        {
            Console.WriteLine("TestBindingList():");

            var data1 = new BindingList<int>(new List<int>(CreateSequence(100, 0, 5)));
            var data2 = new BindingList<int>(CreateSequence(100, 0, 5).ToList());

            data1[5] = 10000;
            foreach (var i in data2)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        static void TestTakeWhileDelegate()
        {
            Console.WriteLine("TestTakeWhileDelegate():");

            // 匿名デリゲートを使用する
            var sequence = CreateSequence(100000000, 0, 7).
                TakeWhile(delegate (int num) { return num < 1000; });

            foreach (var i in sequence)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        static void TestTakeWhileLambda()
        {
            Console.WriteLine("TestTakeWhileLambda():");

            // ラムダ式を使用する
            var sequence = CreateSequence(100000000, 0, 7).
                TakeWhile((num) => num < 1000);

            foreach (var i in sequence)
                Console.Write("{0} ", i);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestBindingList();
            TestTakeWhileDelegate();
            TestTakeWhileLambda();
        }
    }
}
