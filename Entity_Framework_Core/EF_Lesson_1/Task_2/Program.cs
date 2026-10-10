

namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var context = new ProductContext();

            //if (!context.Products.Any())
            //{
            //    var initialProducts = new List<Product>
            //        {
            //            new Product("Ноутбук", 28500.0m, "Ігровий лептоп", 5),
            //            new Product("Мишка", 850.5m, "Бездротова оптична", 25),
            //            new Product("Клавіатура", 2100.0m, "Механічна RGB", 12),
            //            new Product("Монітор", 9400.0m, "27 дюймів IPS 144Hz", 8),
            //            new Product("Навушники", 3200.0m, "З шумозаглушенням", 15),
            //            new Product("Килимок", 450.0m, "Розмір XL", 40),
            //            new Product("Веб-камера", 1950.0m, "FullHD 60fps", 7),
            //            new Product("Мікрофон", 2700.0m, "Конденсаторний USB", 9),
            //            new Product("Колонки", 1800.0m, "Акустика 2.0", 11),
            //            new Product("USB-хаб", 620.0m, "Type-C на 4 порти", 18)
            //        };

            //    context.Products.AddRange(initialProducts);
            //    int savedCount = context.SaveChanges();

            //    Console.WriteLine($"Успішно збережено нових записів у БД: {savedCount}\n");
            //}
            //else
            //{
            //    Console.WriteLine("Дані вже існують у базі, запис неможливий.\n");
            //}
            //int totalInDb = context.Products.Count();
            //Console.WriteLine($"Загальна кількість товарів у таблиці Products: {totalInDb}\n");


            //string[] targetNames = { "Мишка", "Килимок", "Ноутбук", "Мікрофон" };

            //Console.WriteLine("=== Результати пошуку товарів за Name у контексті БД ===");

            //foreach (string name in targetNames)
            //{
            //    Product? product = context.Products.FirstOrDefault(p => p.Name == name);
            //    if (product != null)
            //    {
            //        Console.WriteLine($"Знайдено: {product}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Товар з назвою \"{name}\" не знайдено.");
            //    }
            //}
            try
            {
                Console.WriteLine("Спроба отримати елемент за некоректним від'ємним індексом...");

                int invalidIndex = -5;

                var product = context.Products.AsEnumerable().ElementAt(invalidIndex);

                Console.WriteLine($"Отримано: {product.Name}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Виникло виключення: {ex.Message}");
                Console.ResetColor();

                var errorEntry = new Error
                {
                    Time = DateTime.Now,
                    Status = StatusCode.NotFound,
                    Request = "Query Products by negative index (-5)",
                    Message = ex.Message
                };

                context.Errors.Add(errorEntry);

                Console.WriteLine("\nПомилку успішно зафіксовано в контексті Errors!");
            }

            Console.WriteLine("\n=== Помилки в пам'яті контексту ===");
            foreach (var err in context.Errors)
            {
                Console.WriteLine(err);
            }
            Console.ReadKey();
        }
    }
}
