using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyWidgetLib;

namespace MyWidgetClient
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
