using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroInitialize
{
    class Program
    {
        static MyValType myVal1;

        static void Main(string[] args)
        {
            // 2019.03.04: 未割当のローカル変数
            //MyValType myVal1;
            MyValType myVal2 = new MyValType();

            Console.WriteLine($"myVal1.IntVal: {myVal1.IntVal}, myVal1.DoubleVal: {myVal1.DoubleVal}, myVal1.ListVal: {myVal1.ListVal}");
            Console.WriteLine($"myVal2.IntVal: {myVal2.IntVal}, myVal2.DoubleVal: {myVal2.DoubleVal}, myVal2.ListVal: {myVal2.ListVal}");
        }
    }
}
