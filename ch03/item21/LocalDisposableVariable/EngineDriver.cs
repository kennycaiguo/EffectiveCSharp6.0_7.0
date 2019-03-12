using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDisposableVariable
{
    public interface IEngine
    {
        void DoWork();
    }

    public class EngineDriverOne<T> where T : IEngine, new()
    {
        public void GetThingsDone()
        {
            T driver = new T();
            driver.DoWork();
        }
    }

    public class EngineDriver2<T> where T : IEngine, new()
    {
        public void GetThingsDone()
        {
            T driver = new T();
            using (driver as IDisposable)
            {
                driver.DoWork();
            }
        }
    }
}
