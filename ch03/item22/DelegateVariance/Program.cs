using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVariance
{
    class Program
    {
        static void TestICovariantDelegate()
        {
            Console.WriteLine("TestICovariantDelegata():");

            var supplier = new IntSupplier(123);
            int result;

            result = supplier.GetAnItem();
            Console.WriteLine($"supplier.GetAnItem(): {result}");

            var func = supplier.GetAnItemLater();
            result = func();
            Console.WriteLine($"var func = supplier.GetAnItemLater(); func(): {result}");

            Console.WriteLine("supplier.GiveAnItemLater((v) => Console.WriteLine(v)):");
            supplier.GiveAnItemLater((v) => Console.WriteLine(v));
        }

        static void TestIContravariantDelegate()
        {
            Console.WriteLine("TestIContravariantDelegata():");

            var consumer = new IntConsumer();
            int result;
            Action<int> action;

            consumer.ActOnAnItem(123);
            result = consumer.Value;
            Console.WriteLine($"consumer.ActOnAnItem(123); consumer.Value: {result}");

            consumer.GetAnItemLater(() => 456);
            result = consumer.Value;
            Console.WriteLine($"consumer.GetAnItemLater(() => 456); consumer.Value: {result}");

            action = consumer.ActOnAnItemLater();
            action(789);
            result = consumer.Value;
            Console.WriteLine($"action = consumer.ActOnAnItemLater(); action(789); consumer.Value: {result}");
        }

        static void Main(string[] args)
        {
            TestICovariantDelegate();
            TestIContravariantDelegate();
        }
    }
}
