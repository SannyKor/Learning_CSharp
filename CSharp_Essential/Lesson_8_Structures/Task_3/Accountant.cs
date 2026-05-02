using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    public class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            int norm = (int)worker;
            if (hours > norm)
                return true;
            return false;
        }
    }
}
