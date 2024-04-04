using Library_Managment.Models;

namespace Library_Managment.Interfaces;

public interface IBookService
{
    public Book AddNewBook(Book book);
    public Book DisplayBookDetails(int id);
    public Book UpdateBook(Book book);
    public bool DeleteBook(int id);
    public List<Book> GetBooks();
}

