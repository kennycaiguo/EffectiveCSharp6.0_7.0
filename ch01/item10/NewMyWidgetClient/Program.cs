using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NewMyWidgetLib;

namespace NewMyWidgetClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var myWidget = new MyWidget();
            myWidget.MyFunction();
            myWidget.NormalizeValues();
        }
    }
}
