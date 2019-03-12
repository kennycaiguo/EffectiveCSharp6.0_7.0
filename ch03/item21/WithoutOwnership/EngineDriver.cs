using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutOwnership
{
    public interface IEngine
    {
        void DoWork();
    }

    public sealed class EngineDriver<T> where T : IEngine
    {
        // 生成コストが高いため、nullに初期化
        private T driver;
        public EngineDriver(T driver)
        {
            this.driver = driver;
        }
        public void GetThingsDone()
        {
            driver.DoWork();
        }
    }
}
