using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4_NVI_
{
    class Administrator : UserAuthorization
    {
        protected override bool CheckCredentials()
        {
            Console.WriteLine("Перевірка логіна, пароля та коду адміністратора.");
            return false;
        }
    }
}
