using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    public class MyClass
    {
        // コレクションの宣言と同時に初期化
        private List<string> labels = new List<string>();

        public List<string> Labels { get { return labels; } }
    }
}
