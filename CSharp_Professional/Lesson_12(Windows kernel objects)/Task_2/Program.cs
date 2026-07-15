using System.Text;

namespace Task_2
{
    class Program
    {
        // false - встановлення несигнального стану.
        static AutoResetEvent auto = new AutoResetEvent(false);

        static void Function()
        {
            Console.WriteLine("Запущений потік {0}", Thread.CurrentThread.Name);

            for (int i = 0; i < 80; i++)
            {
                Console.Write(".");
                Thread.Sleep(20);
            }

            Console.WriteLine("Завершений потік {0}", Thread.CurrentThread.Name);

            auto.Set(); // Посилає сигнал первинного потоку - [тривати].
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Thread thread = new Thread(Function) { Name = "1" }; // 1-й ПОТОК.
            thread.Start();

            Console.WriteLine("Призупинення виконання первинного потоку.");
            auto.WaitOne();

            Console.WriteLine("Первинний потік відновив роботу.");

            //auto.Reset(); // Встановлення несигнального стану [AutoResetEvent(false)].

            thread = new Thread(Function) { Name = "2" }; // 2-й ПОТІК.
            thread.Start();

            Console.WriteLine("Призупинення виконання первинного потоку.");
            auto.WaitOne();

            Console.WriteLine("Первинний потік відновив та завершив роботу.");

            // Delay
            Console.ReadKey();
        }
    }
}
