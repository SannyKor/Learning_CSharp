namespace Task_4_NVI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAuthorization user = new User();
            UserAuthorization admin = new Administrator();

            Console.WriteLine("Авторизація користувача:");
            user.Login();

            Console.WriteLine("Авторизація адміністратора:");
            admin.Login();

            Console.ReadKey();
        }
    }
}
