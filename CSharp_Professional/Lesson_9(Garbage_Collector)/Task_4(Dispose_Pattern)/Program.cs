namespace Task_4_Dispose_Pattern_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"До створення об'єкта: {GC.GetTotalMemory(false) / 1024 / 1024} МБ");

            using (BigData data = new BigData())
            {
                data.Fill();

                Console.WriteLine($"Після створення об'єкта: {GC.GetTotalMemory(false) / 1024 / 1024} МБ");
            }

            Console.WriteLine("Dispose викликано.");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine($"Після GC: {GC.GetTotalMemory(true) / 1024 / 1024} МБ");
        }
    }
}
