namespace Task_4_Redo_the_task_from_Les_11_
{
    public class Program
    {
        static int counter = 0;

        // Змінюємо на посилальний тип. Об'єкт блокування має бути reference-типом.
        // static readonly гарантує, що посилання на об'єкт не зміниться під час роботи.
        private static readonly object blockLock = new object();

        static async Task Function()
        {
            for (int i = 0; i < 20; ++i)
            {
                // Використовуємо оператор lock — це безпечна обгортка над Monitor.Enter/Exit
                lock (blockLock)
                {
                    // Тепер цей блок коду виконується лише одним потоком одночасно
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {++counter}");
                }
                await Task.Delay(100);
            }
        }

        static async Task Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Task[] tasks =
            {
                Function(),
                Function(),
                Function()
            };
            await Task.WhenAll(tasks);
            Console.WriteLine("Усі задачі завершені.");
            // Delay
            Console.ReadKey();
        }
    }
}
