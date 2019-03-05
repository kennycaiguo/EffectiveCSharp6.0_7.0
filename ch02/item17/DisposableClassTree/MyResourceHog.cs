using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableClassTree
{
    class MyResourceHog : IDisposable
    {
        // すでに破棄済みかどうかを示すフラグ
        private bool alreadyDisposed = false;

        // IDisposableの実装
        // virtual Dispose(bool)を呼ぶ他にファイナライゼイションを抑制する
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // virtual Dispose(bool)メソッド
        protected virtual void Dispose(bool isDisposing)
        {
            // 2回以上は破棄処理を行わないようにする
            if (alreadyDisposed)
                return;

            if (isDisposing)
            {
                // この位置でマネージリソースを開放する
                Console.WriteLine("release managed resource of MyResourceHog");
            }
            // この位置で非マネージリソースを開放する
            Console.WriteLine("release non-managed resource of MyResourceHog");

            // 破棄済みのフラグを設定
            alreadyDisposed = true;
        }

        public void ExampleMethod()
        {
            if (alreadyDisposed)
                throw new ObjectDisposedException(
                    nameof(MyResourceHog),
                    "破棄済みのオブジェクトでExampleMethodが呼ばれました");
        
            // その他のコードは省略
        }
    }
}
