using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateIntList
{
    class Program
    {
        static IList<int> CreateSequence(int numberOfElements,
            int startAt, int stepBy)
        {
            var collection =
                new List<int>(numberOfElements);
            for (int i = 0; i < numberOfElements; i++)
                collection.Add(startAt + i * stepBy);
            return collection;
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

        static void TestBindingList()
        {
            Console.WriteLine("TestBindingList():");

            var list = CreateSequence(100, 0, 5);
            var data1 = new BindingList<int>(list);
            var data2 = new BindingList<int>(list);

            data1[5] = 10000;
            foreach (var i in data2)
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
