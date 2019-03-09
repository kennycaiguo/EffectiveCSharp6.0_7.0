using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraint
{
    class Program
    {
        static void EqualityOfString()
        {
            Console.WriteLine("EqualityOfString():");

            string s1 = "abc";
            string s2 = "xyz";
            string s_null = null;
            bool result;

            Console.Write("Utiles.AreEqual(s1, s1): ");
            result = Utils.AreEqual(s1, s1);
            Console.WriteLine(result);

            Console.Write("Utiles.AreEqual(s1, s2): ");
            result = Utils.AreEqual(s1, s2);
            Console.WriteLine(result);

            Console.Write("Utiles.AreEqual(s_null, s2): ");
            result = Utils.AreEqual(s_null, s2);
            Console.WriteLine(result);

            // 2019.03.09: ArgumentException occurs
            try
            {
                Console.Write("Utiles.AreEqual(s1, s_null): ");
                result = Utils.AreEqual(s1, s_null);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Write("Utiles.AreEqual(s_null, s_null): ");
            result = Utils.AreEqual(s_null, s_null);
            Console.WriteLine(result);
        }

        static void EqualityOfPoint()
        {
            Console.WriteLine("EqualityOfPoint():");

            Point p1 = new Point { X = 1, Y = 2 };
            Point p2 = new Point { X = 10, Y = 20 };
            OrderedPoint op1 = new OrderedPoint { X = 1, Y = 2 };
            OrderedPoint op2 = new OrderedPoint { X = 1, Y = 3 };
            bool result;

            try
            {
                Console.Write("Utiles.AreEqual(p1, p1): ");
                result = Utils.AreEqual(p1, p1);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Write("Utiles.AreEqual(op1, op1): ");
            result = Utils.AreEqual(op1, op1);
            Console.WriteLine(result);

            Console.Write("Utiles.AreEqual(op1, op2): ");
            result = Utils.AreEqual(op1, op2);
            Console.WriteLine(result);

            try
            {
                Console.Write("Utiles.AreEqual(op1, p2): ");
                result = Utils.AreEqual(op1, p2);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void EqualityOfString2()
        {
            Console.WriteLine("EqualityOfString2():");

            string s1 = "abc";
            string s2 = "xyz";
            string s_null = null;
            bool result;

            Console.Write("Utiles.AreEqual2(s1, s1): ");
            result = Utils.AreEqual2(s1, s1);
            Console.WriteLine(result);

            Console.Write("Utiles.AreEqual2(s1, s2): ");
            result = Utils.AreEqual2(s1, s2);
            Console.WriteLine(result);

            // 2019.03.09: NullReferenceException occurs
            try
            {
                Console.Write("Utiles.AreEqual2(s_null, s2): ");
                result = Utils.AreEqual2(s_null, s2);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                Console.Write("Utiles.AreEqual2(s1, s_null): ");
                result = Utils.AreEqual2(s1, s_null);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // 2019.03.09: NullReferenceException occurs
            try
            {
                Console.Write("Utiles.AreEqual2(s_null, s_null): ");
                result = Utils.AreEqual2(s_null, s_null);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void EqualityOfPoint2()
        {
            Console.WriteLine("EqualityOfPoint2():");

            Point p1 = new Point { X = 1, Y = 2 };
            Point p2 = new Point { X = 10, Y = 20 };
            OrderedPoint op1 = new OrderedPoint { X = 1, Y = 2 };
            OrderedPoint op2 = new OrderedPoint { X = 1, Y = 3 };
            bool result;
            
            //result = Utils.AreEqual2(p1, p1);
            // 'Constraint.Point' から 'System.IComparable<Constraint.Point>' への暗黙的な参照変換がありません。	Constraint C:\books\EffectiveCSharp6.0_7.0\ch03\item18\Constraint\Program.cs   156 アクティブ

            Console.Write("Utiles.AreEqual2(op1, op1): ");
            result = Utils.AreEqual2(op1, op1);
            Console.WriteLine(result);

            Console.Write("Utiles.AreEqual2(op1, op2): ");
            result = Utils.AreEqual2(op1, op2);
            Console.WriteLine(result);

            //result = Utils.AreEqual2(op1, p2);
            // 'Constraint.Point' から 'System.IComparable<Constraint.Point>' への暗黙的な参照変換がありません。	Constraint C:\books\EffectiveCSharp6.0_7.0\ch03\item18\Constraint\Program.cs   177 アクティブ
        }

        static void Main(string[] args)
        {
            EqualityOfString();
            EqualityOfPoint();

            EqualityOfString2();
            EqualityOfPoint2();
        }
    }
}
