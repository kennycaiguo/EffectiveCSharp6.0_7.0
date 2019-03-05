using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableClassTree
{
    class DerivedResourceHog : MyResourceHog
    {
        // 派生クラス固有の破棄フラグを用意する
        private bool disposed = false;

        protected override void Dispose(bool isDisposing)
        {
            // 2回以上は破棄処理を行わないようにする
            if (disposed)
                return;

            if (isDisposing)
            {
                // この位置でマネージリソースを開放する
                Console.WriteLine("releasing managed resource of DerivedResourceHog");
            }
            // この位置で非マネージリソースを開放する
            Console.WriteLine("releasing non-managed resource of DerivedResourceHog");

            // 親クラスにリソースを開放させる
            // GC.SuppressFinalize()の呼び出しは親クラスに任せる
            base.Dispose(isDisposing);

            //　破棄済みフラグを設定する
            disposed = true;
        }
    }
}
