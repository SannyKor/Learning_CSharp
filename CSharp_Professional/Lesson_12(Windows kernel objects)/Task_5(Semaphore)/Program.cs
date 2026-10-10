using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_5_Semaphore_
{
    public class Program
    {
        private static SemaphoreSlim pool = new SemaphoreSlim(3, 3);
        private static readonly string logPath = "app_access.log";
        private static readonly object logLock = new object();
        static void WriteLog(object? number)
        {
            pool.Wait();
            Console.WriteLine($"Потік {number} зайняв слот семафору.");
            try
            {
                Thread.Sleep(2000);
                lock (logLock)
                {
                    string logMessage = $"[{DateTime.Now:HH:mm:ss.fff}] [УСПІХ] " +
                    $"Потік {number} отримав доступ і записав свій звіт.\n";
                    File.AppendAllText(logPath, logMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка в потоці {number} при записі в лог: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Потік {number} звільнив слот семафору.");
                pool.Release();
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            if(File.Exists(logPath))
            {
                File.Delete(logPath);
            }

            List<Thread> threads = new List<Thread>();
            for (int i = 1; i <= 9; i++)
            {
                Thread thread = new Thread(WriteLog);
                thread.Start(i);
                threads.Add(thread);
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
            Console.WriteLine("\n--- Усі потоки завершили роботу ---");
            Console.WriteLine("Вміст створеного файлу app_access.log:\n");
           

            string logContent = File.ReadAllText(logPath);
            Console.WriteLine(logContent);
        }
    }
}
