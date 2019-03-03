using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UpdatedMyWidgetLib;

namespace UpdatedMyWidgetClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var myWidget = new MyWidget();
            myWidget.MyFunction();
            myWidget.NormalizeAllValues();
        }
    }
}
