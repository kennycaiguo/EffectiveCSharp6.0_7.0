using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInitializer
{
    public struct ImportantData
    {

    }

    public class MyClass
    {
        // コレクションデータ
        private List<ImportantData> col1;

        // インスタンス名
        private string name;

        public List<ImportantData> Collection { get { return col1; } }
        public string Name { get { return name; } }

        public MyClass() :
            this(0, "")
        {
        }

        public MyClass(int initialCount) :
            this(initialCount, string.Empty)
        {
        }

        public MyClass(int initialCount, string name)
        {
            col1 = (initialCount > 0) ?
                new List<ImportantData>(initialCount) :
                new List<ImportantData>();
            this.name = name;
        }
    }
}
