

using Microsoft.EntityFrameworkCore;
using Task_2.Models;

namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //var context = new ProductContext();

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
            //try
            //{
            //    Console.WriteLine("Спроба отримати елемент за некоректним від'ємним індексом...");

            //    int invalidIndex = -5;

            //    var product = context.Products.AsEnumerable().ElementAt(invalidIndex);

            //    Console.WriteLine($"Отримано: {product.Name}");
            //}
            //catch (Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"Виникло виключення: {ex.Message}");
            //    Console.ResetColor();

            //    var errorEntry = new Error
            //    {
            //        Time = DateTime.Now,
            //        Status = StatusCode.NotFound,
            //        Request = "Query Products by negative index (-5)",
            //        Message = ex.Message
            //    };

            //    context.Errors.Add(errorEntry);

            //    Console.WriteLine("\nПомилку успішно зафіксовано в контексті Errors!");
            //}

            //Console.WriteLine("\n=== Помилки в пам'яті контексту ===");
            //foreach (var err in context.Errors)
            //{
            //    Console.WriteLine(err);
            //}
            //Console.ReadKey();
            using (var context = new ProductContext())
            {
                if (!context.Categories.Any())
                {
                    var wMak = new Word { Header = "Інгредієнт", KeyWord = "Мак" };
                    var wBulka = new Word { Header = "Тип", KeyWord = "Булка" };
                    var wPovidlo = new Word { Header = "Інгредієнт", KeyWord = "Повидло" };
                    var wDell = new Word { Header = "Бренд", KeyWord = "Dell" };
                    var wWireless = new Word { Header = "Тип", KeyWord = "Бездротова" };
                    var wCoffee = new Word { Header = "Тип", KeyWord = "Кава" };
                    var wCold = new Word { Header = "Температура", KeyWord = "Холодний" };

                    context.Words.AddRange(wMak, wBulka, wPovidlo, wDell, wWireless, wCoffee, wCold);


                    var catBakery = new Category { Name = "Випічка", Icon = "bakery.png" };
                    var catTech = new Category { Name = "Техніка", Icon = "tech.png" };
                    var catDrinks = new Category { Name = "Напої", Icon = "drinks.png" };


                    var p1 = new Product { Name = "Булочка з маком", Cost = 25, ActionCost = 20, Category = catBakery };
                    var p2 = new Product { Name = "Булочка з повидлом", Cost = 22, ActionCost = 18, Category = catBakery };
                    var p3 = new Product { Name = "Рогалик", Cost = 18, ActionCost = 15, Category = catBakery };

                    var p4 = new Product { Name = "Ноутбук", Cost = 32000, ActionCost = 29500, Category = catTech };
                    var p5 = new Product { Name = "Мишка", Cost = 950, ActionCost = 800, Category = catTech };

                    var p6 = new Product { Name = "Американо", Cost = 45, ActionCost = 40, Category = catDrinks };
                    var p7 = new Product { Name = "Айс Латте", Cost = 65, ActionCost = 55, Category = catDrinks };

                    context.Products.AddRange(p1, p2, p3, p4, p5, p6, p7);

                    
                    context.KeyParams.AddRange(
                        new KeyParams { Product = p1, Keywords = wMak },
                        new KeyParams { Product = p1, Keywords = wBulka },
                        new KeyParams { Product = p2, Keywords = wBulka },
                        new KeyParams { Product = p2, Keywords = wPovidlo },
                        new KeyParams { Product = p3, Keywords = wBulka },
                        new KeyParams { Product = p4, Keywords = wDell },
                        new KeyParams { Product = p5, Keywords = wWireless },
                        new KeyParams { Product = p6, Keywords = wCoffee },
                        new KeyParams { Product = p7, Keywords = wCoffee },
                        new KeyParams { Product = p7, Keywords = wCold }
                    );

                    var u1 = new User { Name = "Vlad", Login = "vlad", Password = "123", Email = "vlad@test.com" };
                    var u2 = new User { Name = "Anna", Login = "anna", Password = "456", Email = "anna@test.com" };

                    context.Users.AddRange(u1, u2);

                    context.Carts.AddRange(
                        new Cart { User = u1, Product = p4 }, // Vlad купив Ноутбук
                        new Cart { User = u2, Product = p1 }, // Anna купила Булочку з маком
                        new Cart { User = u2, Product = p6 }  // Anna купила Американо
                    );

                    context.SaveChanges();
                }

                // ================= ВИВЕДЕННЯ У КОНСОЛЬ =================

                // 1. Користувачі та їх придбані продукти з ключовими словами
                Console.WriteLine("User");
                var users = context.Users
                    .Include(u => u.Carts)
                        .ThenInclude(c => c.Product)
                            .ThenInclude(p => p.Keywords)
                                .ThenInclude(kp => kp.Keywords)
                    .ToList();

                foreach (var user in users)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"-{user.Name}");
                    Console.ResetColor();

                    foreach (var cartItem in user.Carts)
                    {
                        var productKeywords = cartItem.Product.Keywords.Select(k => k.Keywords.KeyWord);
                        string kwString = string.Join(" | ", productKeywords);
                        if (!string.IsNullOrEmpty(kwString)) kwString += " | ";

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"--{cartItem.Product.Name} ( ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(kwString);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(")");
                    }
                    Console.WriteLine();
                }

                // 2. Категорії та їх продукти з ключовими словами
                Console.WriteLine("Category");
                var categories = context.Categories
                    .Include(c => c.Products)
                        .ThenInclude(p => p.Keywords)
                            .ThenInclude(kp => kp.Keywords)
                    .ToList();

                foreach (var category in categories)
                {
                    // Збираємо унікальні ключові слова всіх продуктів даної категорії
                    var allCatKeywords = category.Products
                        .SelectMany(p => p.Keywords)
                        .Select(kp => kp.Keywords.KeyWord)
                        .Distinct()
                        .ToList();

                    string catKwString = string.Join(" | ", allCatKeywords);
                    if (!string.IsNullOrEmpty(catKwString)) catKwString += " | ";

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"-{category.Name} ( ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(catKwString);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(")");
                    Console.ResetColor();

                    foreach (var product in category.Products)
                    {
                        var productKeywords = product.Keywords.Select(k => k.Keywords.KeyWord);
                        string pKwString = string.Join(" | ", productKeywords);
                        if (!string.IsNullOrEmpty(pKwString)) pKwString += " | ";

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write($"--{product.Name} ( ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(pKwString);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(")");
                    }
                    Console.WriteLine();
                }

                Console.ResetColor();
                Console.WriteLine("finish");
            }

            Console.ReadLine();
        }
    }
}
