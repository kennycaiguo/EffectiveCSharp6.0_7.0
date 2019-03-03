using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BaseWidgetLib;



namespace MyWidgetLib
{
    public class MyWidget : BaseWidget
    {
        public void MyFunction()
        {
            Console.WriteLine("MyWidget.MyFunction()");
            BaseFunction();
        }

        public void NormalizeValues()
        {
            Console.WriteLine("MyWidget.NormalizeValues()");
        }
    }
}
