namespace Task_2_Parallel_Invoke_
{
    internal class Program
    {
        private static readonly object consoleLock = new object();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Main запущений. Thread = {Environment.CurrentManagedThreadId}");
            
            Task.Run(() => { Parallel.Invoke(Method1, Method2); });

            for (int i = 0; i < 5; i++)
            {
                lock (consoleLock)
                {
                    Console.WriteLine($"Main Thread {Environment.CurrentManagedThreadId} - {i}");
                }
                
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Main завершений.");
            Console.ReadLine();
        }
        static void Method1()
        {
            string indent = new string(' ', 15);
            lock (consoleLock)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{indent}Method1 запущений. Thread = {Environment.CurrentManagedThreadId}");
                Console.ResetColor();
            }
            for (int i = 0; i < 5; i++)
            {
                lock (consoleLock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{indent}Method1 Thread {Environment.CurrentManagedThreadId} - {i}");
                    Console.ResetColor();
                }
                Thread.Sleep(1000);
            }
            lock (consoleLock)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{indent}Method1 завершений.");
                Console.ResetColor();
            }
        }
        static void Method2()
        {
            string indent = new string(' ', 30);
            lock (consoleLock)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{indent}Method2 запущений. Thread = {Environment.CurrentManagedThreadId}");
                Console.ResetColor();
            }
            for (int i = 0; i < 5; i++)
            {
                lock (consoleLock)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{indent}Method2 Thread {Environment.CurrentManagedThreadId} - {i}");
                    Console.ResetColor();
                }
                Thread.Sleep(1000);
            }
            lock (consoleLock)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{indent}Method2 завершений.");
                Console.ResetColor();
            }
        }
    }
}
