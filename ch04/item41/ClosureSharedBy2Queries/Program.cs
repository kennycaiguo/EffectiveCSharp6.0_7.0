using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosureSharedBy2Queries
{
    class Program
    {
        private static IEnumerable<int> LeakingClosure(int mod)
        {
            var filter = new ResourceHogFilter();
            var source = new CheapNumberGenerator();
            var results = new CheapNumberGenerator();

            var importantStatistic = (from num in
                                          source.GetNumbers(50)
                                      where filter.ParsesFilter(num)
                                      select num).Average();

            return from num in results.GetNumbers(100)
                   where num > importantStatistic
                   select num;
        }

        private static IEnumerable<int> NonLeakingClosure(int mod)
        {
            var importantStatistic = GenerateImportantStatistic();

            var results = new CheapNumberGenerator();
            return from num in results.GetNumbers(100)
                   where num > importantStatistic
                   select num;
        }

        private static double GenerateImportantStatistic()
        {
            var filter = new ResourceHogFilter();
            var source = new CheapNumberGenerator();

            return (from num in source.GetNumbers(50)
                    where filter.ParsesFilter(num)
                    select num).Average();
        }

        static void TestLeakingClosure()
        {
            Console.WriteLine("TestLeakingClosure():");

            var sequence = LeakingClosure(100);

            Console.WriteLine("collecting garbage after sequence = LeakingClosure()");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放

            foreach (var e in sequence)
                Console.Write($"{e} ");
            Console.WriteLine();

            Console.WriteLine("collecting garbage after foreach (... in sequence)");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
        }

        static void TestNonLeakingClosure()
        {
            Console.WriteLine("TestNonLeakingClosure():");

            var sequence = NonLeakingClosure(100);

            Console.WriteLine("collecting garbage after sequence = NonLeakingClosure()");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放

            foreach (var e in sequence)
                Console.Write($"{e} ");
            Console.WriteLine();

            Console.WriteLine("collecting garbage after foreach (... in sequence)");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
        }

        static void Main(string[] args)
        {
            TestLeakingClosure();
            Console.WriteLine("collecting garbage after TestLeakingClosure() returned");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放

            TestNonLeakingClosure();
            Console.WriteLine("collecting garbage after TestNonLeakingClosure() returned");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
        }
    }
}
