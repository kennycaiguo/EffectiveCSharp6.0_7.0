using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NewBaseWidgetLib;

namespace UpdatedMyWidgetLib
{
    public class MyWidget : BaseWidget
    {
        public void MyFunction()
        {
            Console.WriteLine("MyWidget.MyFunction()");
            BaseFunction();
        }

        public void NormalizeAllValues()
        {
            Console.WriteLine("MyWidget.NormalizeAllValues(): renamed version");

            // 偶然、親クラスの新しいメソッドが同じ処理を行う場合に限り
            //　親クラスのメソッドを呼び出す
            base.NormalizeValues();
        }
    }
}
