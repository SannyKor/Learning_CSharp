using Task_4;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

Store store = new Store("SuperStore");
Article article1 = new Article("TV", store.StoreName, 15000);
Article article2 = new Article("Laptop", store.StoreName, 25000);
Article article3 = new Article("Smartphone", store.StoreName, 10000);
store.AddArticle(article1);
store.AddArticle(article2);
store.AddArticle(article3);





Console.WriteLine(new string('-', 20));
bool exit = false;
while (!exit)
{
    Console.WriteLine("Оберіть дію:" +
        "\n1. - додати товар." +
        "\n2. - знайти товар за назвою." +
        "\n3. - знайти товар за індексом." +
        "\n4. - знайти товар за назвою з використанням індексатора." +
        "\n5. - вийти.");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Введіть назву товару:");
            string name = Console.ReadLine();
            Console.WriteLine("Введіть ціну товару:");
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Невірний формат ціни. Спробуйте ще раз:");
            }
            Article article = new Article(name, store.StoreName, price);
            if (store.AddArticle(article))
                Console.WriteLine("Товар успішно додано.");
            break;
        case "2":
            while (true)
            {
                Console.WriteLine("Введіть назву товару для пошуку:");
                Article findedArticle = store.FindArticleByName(Console.ReadLine());
                if (findedArticle == null)
                    Console.WriteLine("Товар не знайдено за вказаною назвою.");
                else
                    findedArticle.DisplayInfo();
                Console.WriteLine("Бажаєте продовжити пошук? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
            break;
        case "3":
            Console.WriteLine("Введіть індекс товару для пошуку:");
            int index;
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Невірний формат індексу. Спробуйте ще раз:");
            }
            try
            {
                if (store[index] != null)
                    store[index].DisplayInfo();
                else
                    Console.WriteLine("Товар не знайдено за вказаним індексом.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Індекс виходить за межі масиву.");
            }
            break;
        case "4": // Пошук товару за назвою з використанням індексатора.
            while (true)
            {
                Console.WriteLine("Введіть назву товару для пошуку:");
                string input = Console.ReadLine();
                if (store[input] == null)
                    Console.WriteLine("Товар не знайдено за вказаною назвою.");
                else
                    store[input].DisplayInfo();
                Console.WriteLine("Бажаєте продовжити пошук? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            break;
    }       
}