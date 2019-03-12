using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOwnership
{
    public class DisposableEngine : IEngine, IDisposable
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
            {
                Console.WriteLine("DisposableEngine is already disposed");
                return;
            }

            if (isDisposing)
            {
                // この位置でマネージリソースを開放する
                Console.WriteLine("releasing managed resource of DisposableEngine");
            }
            // この位置で非マネージリソースを開放する
            Console.WriteLine("releasing non-managed resource of DisposableEngine");

            // 破棄済みのフラグを設定
            alreadyDisposed = true;
        }

        public void DoWork()
        {
            if (alreadyDisposed)
                throw new ObjectDisposedException(
                    nameof(DisposableEngine),
                    "破棄済みのオブジェクトでDoWorkが呼ばれました");

            Console.WriteLine("DisposableEngine.DoWork()");
        }
    }
}
