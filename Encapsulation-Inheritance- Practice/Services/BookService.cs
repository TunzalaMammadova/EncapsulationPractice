using System;



public class BookService
{
   private Book[] GetAll()
   {
        Book book1 = new()
        {
            id = 1,
            Name = "Test1",
            Author = "Musfiq",
            PageCount = 200

        };


        Book book2 = new()
        {
            id = 2,
            Name = "Test2",
            Author = "Nizami",
            PageCount = 550

        };


        Book book3 = new()
        {
            id = 1,
            Name = "Test3",
            Author = "Cavid",
            PageCount = 330

        };

        return new Book[] { book1, book2, book3 };

   }


    public Book[] GetAllByAuthor(string author)
    {
        Book[] books = GetAll();

        Book[] filteredBooks = books.Where(m => m.Author == author).ToArray();

        return filteredBooks;
    }

    public Book GetById(int id)
    {
        Book[] books = GetAll();

        Book book = books.FirstOrDefault(m => m.id == id);

        return book;
    }

    public Book[] SearchByName(string searchText)
    {
        return GetAll().Where(m => m.Name.ToLower().Contains(searchText.ToLower())).ToArray();


    }
}



