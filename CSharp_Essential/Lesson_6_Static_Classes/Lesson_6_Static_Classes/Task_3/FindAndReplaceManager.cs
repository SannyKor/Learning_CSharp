using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    static class FindAndReplaceManager
    {
        static Book book;

        public static void FindNext(string str)
        {
            if (book == null)
            {
                Console.WriteLine("Книга не додана. Будь ласка, додайте книгу перед пошуком.");
                return;
            }

            book.FindNext(str);
        }
        public static void AddBook(Book b)
        {
            book = b;
        }
    }
}
