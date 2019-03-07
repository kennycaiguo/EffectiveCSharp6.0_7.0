using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = Factory.GetObject();

            // バージョン 1：
            //　oはSecondType型：
            MyType t = o as MyType;　//　失敗。oはMyTypeではない
            if (t != null)
            {
                // MyType型の変数tを使った作業
                Console.WriteLine("o is MyType");
            }
            else
            {
                //　処理の失敗を通知
                Console.WriteLine("o is not MyType");
            }

            // バージョン 2：
            try
            {
                MyType t1;
                t1 = (MyType)o; //　失敗。oはSecondTypeではない

                //　MyType型の変数tを使った作業
                Console.WriteLine("o is casted to MyType");
            }
            catch (InvalidCastException)
            {
                //　処理の失敗を通知
                Console.WriteLine("o is not casted to MyType");
            }

            // バージョン 3：
            SecondType st = o as SecondType;
            try
            {
                MyType t1;
                t1 = (MyType)st;

                //　MyType型の変数tを使った作業
                Console.WriteLine("o is casted to MyType through SecondType");
            }
            catch (InvalidCastException)
            {
                //　処理の失敗を通知する
                Console.WriteLine("o is not casted to MyType through SecondType");
            }

            // DoStuffWithObject
            DoStuffWithObject(o);

            // compile error
            //MyType t2 = st as MyType;
            // 参照の変換、ボックス変換、アンボックス変換、折り返しの変換、または null 型の変換で、
            // 型 'TypeConversion.SecondType' を 'TypeConversion.MyType' に変換できません。	

        }

        private static void DoStuffWithObject(object o)
        {
            try
            {
                MyType t;
                t = (MyType)o;  //　oはMyType型ではないので失敗する

                //　MyType型の変数tを使った作業
                Console.WriteLine("o is casted to MyType in DoStuffWithObject(o)");
            }
            catch (InvalidCastException)
            {
                //　処理の失敗を通知する
                Console.WriteLine("o is not casted to MyType in DoStuffWithObject(o)");
            }
        }
    }
}
