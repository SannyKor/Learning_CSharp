using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_NVI_
{
    class User : UserAuthorization
    {
        protected override bool CheckCredentials()
        {
            Console.WriteLine("Перевірка логіна та пароля користувача.");
            return true;
        }
    }
}
