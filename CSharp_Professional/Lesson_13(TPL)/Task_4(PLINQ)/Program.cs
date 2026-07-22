namespace Task_4_PLINQ_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] numbers = new int[1000000];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 1000000);
            }

            var oddNumbers = numbers
                .AsParallel()
                .Where(number => number % 2 != 0)
                .ToArray();

            Console.WriteLine($"Знайдено {oddNumbers.Length} непарних чисел.");
            Console.WriteLine("Перші 10 непарних чисел:");
            foreach (var number in oddNumbers.Take(10))
            {
                Console.WriteLine(number);
            }
        }
    }
}
