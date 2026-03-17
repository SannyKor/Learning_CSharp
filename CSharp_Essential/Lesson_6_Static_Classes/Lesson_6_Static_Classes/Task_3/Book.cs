using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
        private Notes[] notesArray = new Notes[10];
        public void AddNote(Notes note)
        {
            for (int i = 0; i < notesArray.Length; i++)
            {
                if (notesArray[i] == null)
                {
                    notesArray[i] = note;
                    Console.WriteLine("Нотатка додана: " + notesArray[i].Title);
                    return;
                }
            }
            Console.WriteLine("Немає місця для нової нотатки.");
        }
        public class Notes
        {
            public string Note { get; set; }
            public string Title { get; set; }
           
            public Notes(string title, string note)
            {
                Title = title;
                Note = note;
            }
        }
    }
}