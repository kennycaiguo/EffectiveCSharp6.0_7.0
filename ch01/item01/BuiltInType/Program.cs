using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInType
{
    class DoubleGetter
    {
        static Double GetMagicNumber()
        {
            return 10;
        }
        public static void Calc()
        {
            var f = GetMagicNumber();
            var total = 100 * f / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void Calc2()
        {
            var total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void CalcDouble()
        {
            double total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }

    }
    class SingleGetter
    {
        static Single GetMagicNumber()
        {
            return 10;
        }
        public static void Calc()
        {
            var f = GetMagicNumber();
            var total = 100 * f / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void Calc2()
        {
            var total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void CalcDouble()
        {
            double total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }

    }
    class DecimalGetter
    {
        static Decimal GetMagicNumber()
        {
            return 10;
        }
        public static void Calc()
        {
            var f = GetMagicNumber();
            var total = 100 * f / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void Calc2()
        {
            var total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void CalcDouble()
        {
            //double total = 100 * GetMagicNumber() / 6;
            double total = (double)(100 * GetMagicNumber() / 6);
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }

    }
    class Int32Getter
    {
        static Int32 GetMagicNumber()
        {
            return 10;
        }
        public static void Calc()
        {
            var f = GetMagicNumber();
            var total = 100 * f / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void Calc2()
        {
            var total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void CalcDouble()
        {
            double total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }

    }
    class Int64Getter
    {
        static Int64 GetMagicNumber()
        {
            return 10;
        }
        public static void Calc()
        {
            var f = GetMagicNumber();
            var total = 100 * f / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void Calc2()
        {
            var total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }
        public static void CalcDouble()
        {
            double total = 100 * GetMagicNumber() / 6;
            Console.WriteLine($"宣言された型：{total.GetType().Name}, 値：{total}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DoubleGetter.Calc();
            SingleGetter.Calc();
            DecimalGetter.Calc();
            Int32Getter.Calc();
            Int64Getter.Calc();

            DoubleGetter.Calc2();
            SingleGetter.Calc2();
            DecimalGetter.Calc2();
            Int32Getter.Calc2();
            Int64Getter.Calc2();

            DoubleGetter.CalcDouble();
            SingleGetter.CalcDouble();
            DecimalGetter.CalcDouble();
            Int32Getter.CalcDouble();
            Int64Getter.CalcDouble();
        }
    }
}
