using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2019.02.23 add
using System.Collections;

namespace ForeachIEnumerable
{
    class MyType
    {
        private int value;
        public MyType(int v)
        {
            this.value = v;
        }
        public void DoStuff()
        {
            Console.WriteLine("MyType.DoStuff() : value=" + value);
        }
    }

    class SecondType
    {
        private MyType _value;

        public SecondType(MyType v)
        {
            _value = v;
        }

        public static implicit operator
            MyType(SecondType t)
        {
            return t._value;
        }
    }

    class Program
    {
        public void UseCollection(IEnumerable theCollection)
        {
            foreach (MyType t in theCollection)
                t.DoStuff();
        }

        public void UseCollectionV2(IEnumerable theCollection)
        {
            IEnumerator it = theCollection.GetEnumerator();
            while (it.MoveNext())
            {
                MyType t = (MyType)it.Current;
                t.DoStuff();
            }
        }

        public void UseCollection_int(IEnumerable theCollection)
        {
            foreach (int t in theCollection)
                Console.WriteLine(t);
        }

        public void UseCollectionV2_int(IEnumerable theCollection)
        {
            IEnumerator it = theCollection.GetEnumerator();
            while (it.MoveNext())
            {
                int t = (int)it.Current;
                Console.WriteLine(t);
            }
        }

        static void Main(string[] args)
        {
            Program prog = new Program();

            IEnumerable collection = new List<MyType>() { new MyType(1), new MyType(2) };
            prog.UseCollection(collection);
            prog.UseCollectionV2(collection);

            IEnumerable ints = new List<int>() { 101, 102, 103 };
            prog.UseCollection_int(ints);
            prog.UseCollectionV2_int(ints);

            IEnumerable secondTypes = new List<SecondType>()
                { new SecondType(new MyType(1)), new SecondType(new MyType(2)) };
            try
            {
                prog.UseCollection(secondTypes);
                prog.UseCollectionV2(secondTypes);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("InvalidCastException: " + e);
            }
        }
    }
}
