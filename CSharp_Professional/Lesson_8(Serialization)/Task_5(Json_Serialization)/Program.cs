using System.Text.Json;

namespace Task_5_Json_Serialization_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            UserDto userToSend = new UserDto
            {
                Id = 42,
                Username = "Oleksandr_Dev",
                Email = "developer@example.com",
                CreatedAt = DateTime.UtcNow 
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonload = JsonSerializer.Serialize(userToSend, options);

            Console.WriteLine("--- Об'єкт серіалізовано в JSON (готовий до відправки по мережі) ---");
            Console.WriteLine(jsonload);
            Console.WriteLine(new string('-', 50));

            UserDto? receivedUser = JsonSerializer.Deserialize<UserDto>(jsonload);

            Console.WriteLine("--- Об'єкт успішно десеріалізовано на іншій стороні ---");
            if (receivedUser != null)
            {
                Console.WriteLine($"ID: {receivedUser.Id}");
                Console.WriteLine($"Ім'я: {receivedUser.Username}");
                Console.WriteLine($"Email: {receivedUser.Email}");
                Console.WriteLine($"Дата створення (UTC): {receivedUser.CreatedAt}");
            }
        }
    }
}
