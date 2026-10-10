namespace Task_2_Memory_Monitor_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MemoryMonitor monitor = new MemoryMonitor(100 * 1024 * 1024);
            List<byte[]> data = new();
            while (true)
            {
                data.Add(new byte[10 * 1024 * 1024]);

                monitor.CheckMemory();

                Console.WriteLine("Натисніть Enter...");
                Console.ReadLine();
            }
        }
    }
}
