using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    public class MySynchronizationContext : SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object? state)
        {
             Thread thread = new Thread(() =>
             {
                 try
                 {
                     d(state);
                 }
                 catch (Exception ex)
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine();
                     Console.WriteLine("=== Помилка перехоплена SynchronizationContext ===");
                     Console.WriteLine(ex.Message);
                     Console.ResetColor();
                 }
             });
            thread.Name = "SynchronizationContextThread";
            thread.Start();
        }
    }
}
