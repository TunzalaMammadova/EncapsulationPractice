using System;



public class BookController
{
	private BookService _bookService;

	public BookController()
	{
		_bookService = new BookService();
	}

	public void GetAllByAuthor()
	{
		string authorName = "Nizami";

		BookService bookService = new();

		Book[] result = bookService.GetAllByAuthor(authorName);

		foreach (var item in result)
		{
			Console.WriteLine($"{item.Name} - {item.Author}");

		}
	}

	public void GetById()
	{
		int id = 2;


		var result = _bookService.GetById(id);

		Console.WriteLine(result.Name + " " + result.Author + " " + result.PageCount);
    }

	public void Search()
	{
		var result = _bookService.SearchByName("t");

		foreach (var item in result)
		{
            Console.WriteLine(item.Name);

        }
        
	}
}

