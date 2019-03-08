using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2019.02.24 add
using System.Threading;

namespace TestThreadSafe
{
    public class ClientThread
    {
        private const int SET_CLEAR_COUNT = 500;
        private const int LOOP_COUNT = 1000;
        private const int sleep_ms = 10;

        private EventSource eventSource;
        public int LastCounter { get; set; }
        public bool StopRequest { get; set; }

        public ClientThread(EventSource es)
        {
            eventSource = es;
        }

        void Handler(Object sender, int param)
        {
            LastCounter = param;
        }

        public void exec()
        {
            for (int i = 0; i < LOOP_COUNT; ++i)
            {
                if (StopRequest) break;

                Thread.Sleep(sleep_ms);
                for (int j = 0; j < SET_CLEAR_COUNT; ++j)
                {
                    eventSource.ClearHandler();
                    eventSource.SetHandler(Handler);
                }
            }
        }
    }
}
