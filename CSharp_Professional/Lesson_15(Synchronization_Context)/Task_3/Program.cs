namespace Task_3
{
    public class Program
    {
        static async Task Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SynchronizationContext.SetSynchronizationContext(new MySynchronizationContext());
            await CalculateAsync();
            Console.ReadLine();
        }
        static async Task CalculateAsync()
        {
            PrintThreadInfo("До await");
            long result = await Task.Run(() =>
            {
                PrintThreadInfo("Всередині Task.Run");
                return Factorial(10);
            }).ConfigureAwait(false);
            PrintThreadInfo("Після await");
            Console.WriteLine($"Factorial = {result}");
        }
        static void PrintThreadInfo(string message)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine($"{message}");
            Console.WriteLine($"ManagedThreadId : {thread.ManagedThreadId}");
            Console.WriteLine($"Name            : {thread.Name}");
            Console.WriteLine($"IsThreadPool    : {thread.IsThreadPoolThread}");
            Console.WriteLine();
        }
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
                Thread.Sleep(100);
            }
            return result;
        }
    }
}
