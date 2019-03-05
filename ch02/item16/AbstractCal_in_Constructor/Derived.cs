using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCall_in_Construcotor
{
    class Derived : B
    {
        private readonly string msg = "初期化子で設定";

        public Derived(string msg)
        {
            this.msg = msg;
        }

        protected override void VFunc()
        {
            Console.WriteLine(msg);
        }

        public static void Main()
        {
            var d = new Derived("メイン内のコンストラクタ");
        }
    }
}
