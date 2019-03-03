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
}
