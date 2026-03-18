using Task_3;

Book book = new Book();
FindAndReplaceManager.AddBook(book);
FindAndReplaceManager.FindNext("Hello world");
Book.Notes note1 = new Book.Notes("Note 1", "This is the first note.");
Book.Notes note2 = new Book.Notes("Note 2", "This is the second note.");
book.AddNote(note1);
book.AddNote(note2);
