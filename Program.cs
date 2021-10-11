using System;
using System.Threading;

namespace SimpleCaffeine
{
    class Program
    {
        static void Main(string[] args)
        {
            const int seconds = 10;
            var idleTimer = new Timer(TimerCallback, null, 0, seconds * 1000);
            Console.ReadLine();
        }
        private static void TimerCallback(Object o)
        {
            Console.WriteLine("Proc: " + DateTime.Now);
            Native.SetThreadExecutionState(
                EXECUTION_STATE.ES_CONTINUOUS
                | EXECUTION_STATE.ES_DISPLAY_REQUIRED
                | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
        }

    }
}
