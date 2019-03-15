using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace RuntimeSpecializeBase
{
    public class MyBase
    {
    }

    public interface IMessageWriter
    {
        void WriteMessage();
    }

    public class MyDerived : MyBase, IMessageWriter
    {
        void IMessageWriter.WriteMessage() =>
            WriteLine("MyDerived.WriteMessage 内");
    }

    public class AnotherType : IMessageWriter
    {
        public void WriteMessage() =>
            WriteLine("AnotherType.WriteMessage 内");
    }

    public class SomeType
    {
    }
}
