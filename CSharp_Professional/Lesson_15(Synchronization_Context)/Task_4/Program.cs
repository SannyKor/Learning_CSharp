namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SynchronizationContext.SetSynchronizationContext(new MySynchronizationContext());
            Console.WriteLine("Початок роботи main.");
            PrintThreadInfo();
            try
            {
                DoWork();
                Console.WriteLine("Помилка не була перехоплена в main");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Main продовжив виконання.");

            Console.ReadLine();

        }
        static async void DoWork()
        {
            Console.WriteLine("Початок роботи методу DoWork");
            PrintThreadInfo();
            await Task.Delay(1000);
            Console.WriteLine("\nРобота методу після await:");
            PrintThreadInfo();
            throw new Exception("An error occurred!");
        }
        static void PrintThreadInfo()
        {
            Thread thread = Thread.CurrentThread;

            Console.WriteLine($"ManagedThreadId : {thread.ManagedThreadId}");
            Console.WriteLine($"Name            : {thread.Name}");
            Console.WriteLine($"IsThreadPool    : {thread.IsThreadPoolThread}\n");
        }
    }
}
