using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_NVI_
{
    public abstract class UserAuthorization
    {
        public void Login()
        {
            Console.WriteLine("Початок авторизації...");

            if (CheckCredentials())
            {
                Console.WriteLine("Доступ дозволено.");
            }
            else
            {
                Console.WriteLine("Доступ заборонено.");
            }

            Console.WriteLine("Авторизацію завершено.");
            Console.WriteLine("-------------------------");
        }
        protected abstract bool CheckCredentials();
    }
}
