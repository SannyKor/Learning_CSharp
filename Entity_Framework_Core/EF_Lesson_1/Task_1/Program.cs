namespace Task_1
{
    
    public class Program
    { 
            static void Main(string[] args)
            {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Product> products = new List<Product>
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

                Console.WriteLine("=== 1. Елементи за вказаними індексами (1, 5, 0, 7) ===");
                int[] displayIndexes = { 1, 5, 0, 7 };

                foreach (int index in displayIndexes)
                {
                    if (index >= 0 && index < products.Count)
                    {
                        Console.WriteLine($"[Індекс {index}]: {products[index]}");
                    }
                }
                Console.WriteLine("\n=== 2. Пошук індексів за властивістю Id (для елементів 1 та 5) ===");
                Guid id1 = products[1].Id;
                Guid id5 = products[5].Id;

                int foundIndexId1 = products.FindIndex(p => p.Id == id1);
                int foundIndexId5 = products.FindIndex(p => p.Id == id5);

                Console.WriteLine($"Шуканий Id: {id1} -> Знайдений індекс: {foundIndexId1}");
                Console.WriteLine($"Шуканий Id: {id5} -> Знайдений індекс: {foundIndexId5}");

                
                Console.WriteLine("\n=== 3. Пошук індексів за властивістю Name (для елементів 0 та 7) ===");
                string name0 = products[0].Name;
                string name7 = products[7].Name;

                int foundIndexName0 = products.FindIndex(p => p.Name == name0);
                int foundIndexName7 = products.FindIndex(p => p.Name == name7);

                Console.WriteLine($"Шукаємо Name: \"{name0}\" -> Знайдений індекс: {foundIndexName0}");
                Console.WriteLine($"Шукаємо Name: \"{name7}\" -> Знайдений індекс: {foundIndexName7}");

                Console.ReadLine();
            }
    }
}
