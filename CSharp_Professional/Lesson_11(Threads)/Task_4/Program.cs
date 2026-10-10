using System;
using System.Threading;

namespace monitor
{
    class Program
    {
        static int counter = 0;

        // Змінюємо на посилальний тип. Об'єкт блокування має бути reference-типом.
        // static readonly гарантує, що посилання на об'єкт не зміниться під час роботи.
        private static readonly object blockLock = new object();

        static void Function()
        {
            for (int i = 0; i < 50; ++i)
            {
                // Використовуємо оператор lock — це безпечна обгортка над Monitor.Enter/Exit
                lock (blockLock)
                {
                    // Тепер цей блок коду виконується лише одним потоком одночасно
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {++counter}");
                }
            }
        }

        static void Main()
        {
            Thread[] threads = { new Thread(Function), new Thread(Function), new Thread(Function) };

            foreach (Thread thread in threads)
                thread.Start();

            // Delay
            Console.ReadKey();
        }
    }
}