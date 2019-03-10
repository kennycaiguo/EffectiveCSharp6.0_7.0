using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalOverload
{
    class Program
    {
        static void EqualityOfString()
        {
            Console.WriteLine("EqualityOfString():");

            string s1 = "abc";
            string s1_dash = "abc";
            string s2 = "xyz";
            string s_null = null;
            bool result;

            // 同一の文字列
            Console.Write("Utils.AreEqual(s1, s1): ");
            result = Utils.AreEqual(s1, s1);
            Console.WriteLine(result);

            // 値の等しい、2つの文字列
            Console.Write("Utils.AreEqual(s1, s1_dash): ");
            result = Utils.AreEqual(s1, s1_dash);
            Console.WriteLine(result);

            //　異なる文字列
            Console.Write("Utils.AreEqual(s1, s2): ");
            result = Utils.AreEqual(s1, s2);
            Console.WriteLine(result);

            try
            {
                Console.Write("Utils.AreEqual(s_null, s2): ");
                result = Utils.AreEqual(s_null, s2);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Write("Utils.AreEqual(s1, s_null): ");
            result = Utils.AreEqual(s1, s_null);
            Console.WriteLine(result);

            try
            {
                Console.Write("Utils.AreEqual(s_null, s_null): ");
                result = Utils.AreEqual(s_null, s_null);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Equality2OfString()
        {
            Console.WriteLine("Equality2OfString():");

            string s1 = "abc";
            string s1_dash = "abc";
            string s2 = "xyz";
            string s_null = null;
            bool result;

            //　同一の文字列
            Console.Write("Utils.AreEqual2(s1, s1): ");
            result = Utils.AreEqual2(s1, s1);
            Console.WriteLine(result);

            //　値の等しい、2つの文字列
            Console.Write("Utils.AreEqual(s1, s1_dash): ");
            result = Utils.AreEqual(s1, s1_dash);
            Console.WriteLine(result);

            //　異なる文字列
            Console.Write("Utils.AreEqual2(s1, s2): ");
            result = Utils.AreEqual2(s1, s2);
            Console.WriteLine(result);

            Console.Write("Utils.AreEqual2(s_null, s2): ");
            result = Utils.AreEqual2(s_null, s2);
            Console.WriteLine(result);

            Console.Write("Utils.AreEqual2(s1, s_null): ");
            result = Utils.AreEqual2(s1, s_null);
            Console.WriteLine(result);

            Console.Write("Utils.AreEqual2(s_null, s_null): ");
            result = Utils.AreEqual2(s_null, s_null);
            Console.WriteLine(result);
        }

        static void EqualityOfPointStruct()
        {
            Console.WriteLine("EqualityOfPointStruct():");

            PointStruct p1 = new PointStruct { X = 1, Y = 2 };
            PointStruct p1_dash = new PointStruct { X = 1, Y = 2 };
            PointStruct p2 = new PointStruct { X = 10, Y = 20 };
            bool result;

            // 同一のPointStruct
            Console.Write("Utiles.AreEqual(p1, p1): ");
            result = Utils.AreEqual(p1, p1);
            Console.WriteLine(result);

            // 値の等しい2つのPointStruct
            Console.Write("Utiles.AreEqual(p1, p1_dash): ");
            result = Utils.AreEqual(p1, p1_dash);
            Console.WriteLine(result);

            //　2つの異なるPointStruct
            Console.Write("Utiles.AreEqual(p1, p2): ");
            result = Utils.AreEqual(p1, p2);
            Console.WriteLine(result);
       }

        static void Equality2OfPointClass()
        {
            Console.WriteLine("Equality2OfPointClass():");

            PointClass p1 = new PointClass { X = 1, Y = 2 };
            PointClass p1_dash = new PointClass { X = 1, Y = 2 };
            PointClass p2 = new PointClass { X = 10, Y = 20 };
            bool result;

            // 同一のPointClass
            Console.Write("Utiles.AreEqual2(p1, p1): ");
            result = Utils.AreEqual2(p1, p1);
            Console.WriteLine(result);

            // 値の等しい2つのPointClass
            Console.Write("Utiles.AreEqual2(p1, p1_dash): ");
            result = Utils.AreEqual2(p1, p1_dash);
            Console.WriteLine(result);

            //　2つの異なるPointClass
            Console.Write("Utiles.AreEqual2(p1, p2): ");
            result = Utils.AreEqual2(p1, p2);
            Console.WriteLine(result);
        }

        static void Equality2OfEquatablePointClass()
        {
            Console.WriteLine("Equality2OfEquatablePointClass():");

            EquatablePointClass p1 = new EquatablePointClass { X = 1, Y = 2 };
            EquatablePointClass p1_dash = new EquatablePointClass { X = 1, Y = 2 };
            EquatablePointClass p2 = new EquatablePointClass { X = 10, Y = 20 };
            bool result;

            // 同一のEqutablePointClass
            Console.Write("Utiles.AreEqual2(p1, p1): ");
            result = Utils.AreEqual2(p1, p1);
            Console.WriteLine(result);

            // 値の等しい2つのEqutablePointClass
            Console.Write("Utiles.AreEqual2(p1, p1_dash): ");
            result = Utils.AreEqual2(p1, p1_dash);
            Console.WriteLine(result);

            //　2つの異なるEquatablePointClass
            Console.Write("Utiles.AreEqual2(p1, p2): ");
            result = Utils.AreEqual2(p1, p2);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            EqualityOfString();
            Equality2OfString();

            EqualityOfPointStruct();
            Equality2OfPointClass();
            Equality2OfEquatablePointClass();
        }
    }
}
