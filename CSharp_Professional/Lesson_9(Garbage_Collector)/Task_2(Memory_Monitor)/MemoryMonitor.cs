using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2_Memory_Monitor_
{
    public class MemoryMonitor
    {
        public long MaxMemory { get; set; }
        public double WarningPercent { get; set; } = 0.9;
        public MemoryMonitor (long maxMemory)
        {
            MaxMemory = maxMemory;
        }
        public void CheckMemory()
        {
            long usedMemory = GC.GetTotalMemory(false);
            Console.WriteLine($"Used Memory: {usedMemory / (1024 * 1024)} MB");
            if (usedMemory >= MaxMemory)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Warning: Memory usage is above the threshold!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(usedMemory >= MaxMemory * WarningPercent)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Notice: Memory usage is approaching the threshold.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Memory usage is within acceptable limits.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
