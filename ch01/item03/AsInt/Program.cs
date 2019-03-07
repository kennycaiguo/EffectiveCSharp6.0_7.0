using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsInt
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = Factory.GetValue();

            // can not compile
            //int i = o as int;
            // as 演算子は参照型または Null 許容型で使用してください('int' は Null 非許容の値型です)

            var i = o as int?;
            if (i != null)
                Console.WriteLine(i.Value);
        }
    }
}
