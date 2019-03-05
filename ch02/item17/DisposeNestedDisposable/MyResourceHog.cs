using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeNestedDisposable
{
    class MyResourceHog : IDisposable
    {
        // すでに破棄済みかどうかを示すフラグ
        private bool alreadyDisposed = false;

        private NestedResourceHog nestedResource;

        public MyResourceHog(NestedResourceHog nestedResource)
        {
            this.nestedResource = nestedResource;
        }

        // IDisposableの実装
        // virtual Dispose(bool)を呼ぶ他にファイナライゼイションを抑制する
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // ファイナライザ
        ~MyResourceHog()
        {
            Console.WriteLine("finalizing MyResourceHog");
            Dispose(false);
        }

        // virtual Dispose(bool)メソッド
        protected virtual void Dispose(bool isDisposing)
        {
            // 2回以上は破棄処理を行わないようにする
            if (alreadyDisposed)
            {
                Console.WriteLine("MyResourceHog: already disposed");
                return;
            }

            if (isDisposing)
            {
                // この位置でマネージリソースを開放する
                Console.WriteLine("releasing managed resource of MyResourceHog");
            }
            // この位置で非マネージリソースを開放する
            Console.WriteLine("releasing non-managed resource of MyResourceHog");
            nestedResource.Dispose();

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
