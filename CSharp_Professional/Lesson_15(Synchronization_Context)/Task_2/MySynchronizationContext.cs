using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class MySynchronizationContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object? state)
        {
            Thread thread = new Thread(() => d(state));
            thread.Name = "MySynchronizationContextThread";
            thread.Start();
        }
    }
}
