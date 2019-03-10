using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    class Program
    {
        static void TestInt()
        {
            Console.WriteLine("TestInt():");
            int result;

            result = Utils.Factory(() => 44);
            Console.WriteLine($"Factory(() => 44): {result}");
        }

        static void TestPointStruct()
        {
            Console.WriteLine("TestPointStruct():");
            PointStruct result;

            result = Utils.Factory(() => new PointStruct { X = 1, Y = 2 });
            Console.WriteLine("Factory(() => new PointStruct { X = 1, Y = 2 }): " + result);
        }

        static void TestPointClass()
        {
            Console.WriteLine("TestPointClass():");
            PointClass result;

            result = Utils.Factory(() => new PointClass { X = 1, Y = 2 });
            Console.WriteLine("Factory(() => new PointClass{ X = 1, Y = 2 }): " + result);

            result = Utils.Factory<PointClass>(() => null);
            Console.WriteLine("Factory<PointClass>(() => null): " + result);
        }

        static void Main(string[] args)
        {
            TestInt();
            TestPointStruct();
            TestPointClass();
        }
    }
}
