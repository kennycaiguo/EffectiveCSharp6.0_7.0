using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInitializerMethod
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

        public MyClass()
        {
            commonConstructor(0, "");
        }

        public MyClass(int initialCount)
        {
            commonConstructor(initialCount, "");
        }

        public MyClass(int initialCount, string name)
        {
            commonConstructor(initialCount, name);
        }

        private void commonConstructor(int count, string name)
        {
            col1 = (count > 0) ?
                new List<ImportantData>(count) :
                new List<ImportantData>();
            this.name = name;
        }
    }
}
