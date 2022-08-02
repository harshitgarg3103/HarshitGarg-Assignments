using APIAssignment.Models;
using APIAssignment.Repository;
using System.Collections.Generic;
namespace APIAssignment.Repository
{
    public class RepoClass : RepoInterface
    {
        public static List<Book> books =new List<Book>()
            {
                new Book() { Id=1234,Name="Harshit",price=123.32D,author="John",lang="Hindi",releaseDate=2000}
            };

        public List<Book> GetAllBooks()
        {
        return books;
        }
        public void AddBook(Book book)
        {
        books.Add(book);
        }
        public List<Book> GetBooksByAuthor(string author)
        {
        List<Book> be = new List<Book>();
            foreach(var book in books)
        {
            if (book.author == author)
                be.Add(book);
        }
        return be;
        }
        public List<Book> getBooksByLang(string lang)
        {
        List<Book> be = new List<Book>();
        foreach(var book in books)
        {
            if (book.lang.Equals(lang))
                be.Add(book);
        }
        return be;
        }
        public List<Book> getBooksByYear(int year)
        {
        List<Book> be = new List<Book>();
        foreach(var book in books)
        {
            if (book.releaseDate == year)
                be.Add(book);
        }
        return be;
        }
        public void EditBook()
        {
            
        }
        public void deleteBook(int id)
        {
        Book be = null;
        foreach(var b in books)
        {
            if(b.Id.Equals(id))
            {
                be = b;
            }
        }
        books.Remove(be);
        }
    }
}
