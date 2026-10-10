using System.Text;

namespace Task_3_Mutex_
{
    public class Program
    {
        
        private const string mutexName = "MyUniqueMutexName";

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Створюємо іменований м'ютекс.
            // Параметр initallyOwned: false — ми не намагаємося захопити його одразу при створенні конструктором.
            // Змінна createdNew отримає значення true, якщо м'ютекс із таким ім'ям ще не існував у системі (тобто це перший запуск).
            using (Mutex mutex = new Mutex(false, mutexName, out bool createdNew))
            {
                // Якщо createdNew == false, значить такий м'ютекс уже створено іншим (першим) екземпляром програми.
                if (!createdNew)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка: Один екземпляр програми вже запущено!");
                    Console.ResetColor();

                    Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
                    Console.ReadKey();
                    return; // Завершуємо роботу поточного (другого) екземпляра
                }

                // Якщо ми тут — ми єдиний запущений екземпляр програми.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Програма успішно запущена в одному екземплярі.");
                Console.ResetColor();

                Console.WriteLine("Програма працює. Натисніть Enter, щоб закрити її...");
                Console.ReadLine();
            }
            // Після виходу з блоку using м'ютекс автоматично звільняється та закривається,
            // що дозволить запустити програму знову після її закриття.
        }
    }
}
