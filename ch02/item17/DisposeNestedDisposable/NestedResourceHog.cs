using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeNestedDisposable
{
    class NestedResourceHog : IDisposable
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

        // ファイナライザ
        ~NestedResourceHog()
        {
            Console.WriteLine("finalizing NestedResourceHog");
            Dispose(false);
        }

        // virtual Dispose(bool)メソッド
        protected virtual void Dispose(bool isDisposing)
        {
            // 2回以上は破棄処理を行わないようにする
            if (alreadyDisposed)
            {
                Console.WriteLine("NestedResourceHog: already disposed");
                return;
            }

            if (isDisposing)
            {
                // この位置でマネージリソースを開放する
                Console.WriteLine("releasing managed resource of NestedResourceHog");
            }
            // この位置で非マネージリソースを開放する
            Console.WriteLine("releasing non-managed resource of NestedResourceHog");

            // 破棄済みのフラグを設定
            alreadyDisposed = true;
        }
    }
}
