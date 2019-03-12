using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposableFieldVariable
{
    public interface IEngine
    {
        void DoWork();
    }

    public sealed class EngineDriver2<T> : IDisposable
        where T : IEngine, new()
    {
        // 生成コストが高いため、nullに初期化
        private Lazy<T> driver = new Lazy<T>(() => new T());
        public void GetThingsDone() =>
            driver.Value.DoWork();

        // IDisposableメンバ
        public void Dispose()
        {
            if (driver.IsValueCreated)
            {
                var resource = driver.Value as IDisposable;
                resource?.Dispose();
            }
        }
    }
}
