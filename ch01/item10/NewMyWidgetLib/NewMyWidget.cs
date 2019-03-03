using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NewBaseWidgetLib;

namespace NewMyWidgetLib
{
    public class MyWidget : BaseWidget
    {
        public void MyFunction()
        {
            Console.WriteLine("MyWidget.MyFunction()");
            BaseFunction();
        }

        public new void NormalizeValues()
        {
            Console.WriteLine("MyWidget.NormalizeValues(): new version");
        }
    }
}
