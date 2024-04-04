using Library_Managment.Interfaces;
using Library_Managment.Models;

namespace Library_Managment.Services;

public class BookService : IBookService
{
    List<Book> books;
    public BookService()
    {
        books = new List<Book>();
    }
    public Book AddNewBook(Book book)
    {
        book.Id = books.Count + 1;
        books.Add(book);
        return book;
    }
    public Book UpdateBook(Book book)
    {
        Book foundAndUpdated = null;
        foreach (var item in books)
        {
            if (item.Id == book.Id)
            {
                item.Title = book.Title;
                item.Author = book.Author;
                item.Genre = book.Genre;
                item.PublicationYear = book.PublicationYear;
                foundAndUpdated = item;
            }
        }
        return foundAndUpdated;
    }
    public bool DeleteBook(int id)
    {
        var found = false;
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                books.Remove(book);
                found = true;
                break;
            }
        }
        return found;
    }
    public Book DisplayBookDetails(int id)
    {
        Book found = null;
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                found = book;
                break;
            }
        }
        return found;
    }
    public List<Book> GetBooks()
    {
        return books;
    }
}
