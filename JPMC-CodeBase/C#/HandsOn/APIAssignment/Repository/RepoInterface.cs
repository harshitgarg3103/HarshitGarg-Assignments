using APIAssignment.Models;
using System.Collections.Generic;
namespace APIAssignment.Repository
{
    interface RepoInterface
    {
        public void AddBook(Book book);
        public List<Book> GetAllBooks();
        public List<Book> GetBooksByAuthor(string author);
        public List<Book> getBooksByLang(string lang);
        public List<Book> getBooksByYear(int year);
        public void EditBook();
        public void deleteBook(int id);
    }
}
