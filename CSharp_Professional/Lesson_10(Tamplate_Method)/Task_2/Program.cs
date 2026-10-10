namespace Task_2
{
    public class Program
    {
        static void Main()
        {
            Beverage tea = new Tea();
            Beverage coffee = new Coffee();

            Console.WriteLine("Приготування чаю:");
            tea.Prepare();

            Console.WriteLine("Приготування кави:");
            coffee.Prepare();

            Console.ReadKey();
        }
    }
}
