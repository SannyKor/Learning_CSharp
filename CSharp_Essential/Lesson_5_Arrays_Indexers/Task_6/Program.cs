using System;
using System.Text;

// Індексатори.

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            Console.WriteLine("Пошук за українською мовою:");
            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дім"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["олівець"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["сонце"]);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Пошук за англійською мовою:");
            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["home"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["pensil"]);
            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["sun"]);

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("Пошук за російською мовою:");
            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
