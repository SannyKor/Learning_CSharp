using System;
using System.Collections.Generic;
using System.Text;
using Task_2;

namespace Task_2
{
    static class FindAndReplaceManager
    {
        static Book book = new Book();
        public static void FindNext(string str)
        {
            book.FindNext(str);
        }
    }
}