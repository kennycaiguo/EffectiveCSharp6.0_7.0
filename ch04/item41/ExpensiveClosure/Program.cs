using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensiveClosure
{
    class Program
    {
        IEnumerable<int> ExpensiveSequence()
        {
            int counter = 0;
            var numbers = Extensions.Generate(30,
                () => counter++);
            Console.WriteLine($"counter: {counter}");

            var hog = new ResourceHog();
            numbers = numbers.Union(
                hog.SequenceGeneratedFromResourceHog(
                    (val) => val < counter));
            return numbers;
        }

        IEnumerable<int> ExpensiveSequence2()
        {
            int counter = 0;
            var numbers = Extensions.Generate(30,
                () => counter++);
            Console.WriteLine($"counter: {counter}");

            var hog = new ResourceHog();
            var mergeSequnece = hog.SequenceGeneratedFromResourceHog(
                    (val) => val < counter).ToList();
            numbers = numbers.Union(mergeSequnece);
            return numbers;
        }

        static void TestExpesiveSequence()
        {
            Console.WriteLine("TestExpensiveSequence():");
            var prog = new Program();
            var sequence = prog.ExpensiveSequence();
            foreach (var e in sequence)
                Console.Write($"{e} ");
            Console.WriteLine();

            Console.WriteLine("collecting garbage");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
        }

        static void TestExpesiveSequence2()
        {
            Console.WriteLine("TestExpensiveSequence2():");
            var prog = new Program();
            var sequence = prog.ExpensiveSequence2();
            foreach (var e in sequence)
                Console.Write($"{e} ");
            Console.WriteLine();

            Console.WriteLine("collecting garbage");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
        }

        static void Main(string[] args)
        {
            TestExpesiveSequence();
            Console.WriteLine("collecting garbage after function returned");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放

            TestExpesiveSequence2();
            Console.WriteLine("collecting garbage after function returned");
            System.GC.Collect(); // アクセス不可能なオブジェクトを除去
            System.GC.WaitForPendingFinalizers(); // ファイナライゼーションが終わるまでスレッド待機
            System.GC.Collect(); // ファイナライズされたばかりのオブジェクトに関連するメモリを開放
        }
    }
}
