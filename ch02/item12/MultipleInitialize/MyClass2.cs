using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInitialize
{
    public class MyClass2
    {
        // コレクションを宣言して初期化
        private List<string> labels = new List<string>();

        public List<string> Labels { get { return labels; } }

        public MyClass2()
        {
        }

        public MyClass2(int size)
        {
            labels = new List<string>(size);
        }
    }

    public class MyClass2_internal
    {
        // コレクションを宣言(初期化なし)
        private List<string> labels;

        public List<string> Labels { get { return labels; } }

        public MyClass2_internal()
        {
            labels = new List<string>();
        }

        public MyClass2_internal(int size)
        {
            labels = new List<string>();
            labels = new List<string>(size);
        }
    }
}
