using Task_1;

namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var context = new ProductContext();

            if (!context.Products.Any())
            {
                var initialProducts = new List<Product>
                    {
                        new Product("Ноутбук", 28500.0, "Ігровий лептоп", 5),
                        new Product("Мишка", 850.5, "Бездротова оптична", 25),
                        new Product("Клавіатура", 2100.0, "Механічна RGB", 12),
                        new Product("Монітор", 9400.0, "27 дюймів IPS 144Hz", 8),
                        new Product("Навушники", 3200.0, "З шумозаглушенням", 15),
                        new Product("Килимок", 450.0, "Розмір XL", 40),
                        new Product("Веб-камера", 1950.0, "FullHD 60fps", 7),
                        new Product("Мікрофон", 2700.0, "Конденсаторний USB", 9),
                        new Product("Колонки", 1800.0, "Акустика 2.0", 11),
                        new Product("USB-хаб", 620.0, "Type-C на 4 порти", 18)
                    };

                context.Products.AddRange(initialProducts);
                int savedCount = context.SaveChanges();

                Console.WriteLine($"Успішно збережено нових записів у БД: {savedCount}\n");
            }
            else
            {
                Console.WriteLine("Дані вже існують у базі, запис неможливий.\n");
            }
            int totalInDb = context.Products.Count();
            Console.WriteLine($"Загальна кількість товарів у таблиці Products: {totalInDb}\n");

            
            string[] targetNames = { "Мишка", "Килимок", "Ноутбук", "Мікрофон" };

            Console.WriteLine("=== Результати пошуку товарів за Name у контексті БД ===");

            foreach (string name in targetNames)
            {
                Product? product = context.Products.FirstOrDefault(p => p.Name == name);
                if (product != null)
                {
                    Console.WriteLine($"Знайдено: {product}");
                }
                else
                {
                    Console.WriteLine($"Товар з назвою \"{name}\" не знайдено.");
                }
            }
        }
    }
}
