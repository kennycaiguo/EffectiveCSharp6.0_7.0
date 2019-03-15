using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SpecializeBase
{
    class Program
    {
        static void WriteMessage(MyBase b)
        {
            WriteLine("WriteMessage(MyBase) 内");
        }

        static void WriteMessage<T>(T obj)
        {
            Write("WriteMessage<T>(T) 内: ");
            WriteLine(obj.ToString());
        }

        static void WriteMessage(IMessageWriter obj)
        {
            Write("WriteMessage(IMessageWrite) 内: ");
            obj.WriteMessage(); // virtual call
        }

        static void Main(string[] args)
        {
            MyDerived d = new MyDerived();
            WriteLine("Program.WriteMessage を呼び出し中");
            WriteMessage(d);
            WriteLine();

            WriteLine("IMessageWriter インターフェース経由で呼び出し中");
            WriteMessage((IMessageWriter)d);
            WriteLine();

            WriteLine("親クラスにキャスト");
            WriteMessage((MyBase)d);
            WriteLine();

            WriteLine("別の型をテスト");
            AnotherType anObject = new AnotherType();
            WriteMessage(anObject);
            WriteLine();

            WriteLine("IMessageWriter にキャスト");
            WriteMessage((IMessageWriter)anObject);
        }
    }
}
