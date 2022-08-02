using Microsoft.AspNetCore.Http;
using APIAssignment.Repository;
using APIAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly RepoClass r; 
        public BookController()
        {
            this.r = new RepoClass();
        }
        [HttpGet,Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            List<Book> book = r.GetAllBooks();
            return StatusCode(200, book);
        }
        [HttpGet, Route("GetBooksByAuthor/{author}")]
        public IActionResult GetAllByAuthor(string author)
        {
            List<Book> book = r.GetBooksByAuthor("John");
            return StatusCode(200, book);
        }
        [HttpGet, Route("getBooksByLang/{lang}")]
        public IActionResult GetAllByLanguage(string lang)
        {
            List<Book> book = r.getBooksByLang("Hindi");
            return StatusCode(200, book);
        }
        [HttpGet, Route("getBooksByYear/{releaseDate}")]
        public IActionResult GetAllByYear(int releaseDate)
        {
            List<Book> book = r.getBooksByYear(2000);
            return StatusCode(200, book);
        }
        [HttpPost, Route("AddBook/{book}")]
        public IActionResult CreateBook(Book book)
        {
         
            r.AddBook(book);
            return StatusCode(200, "Book Created");
        }
        [HttpDelete, Route("deleteBook/{id}")]
        public IActionResult DeleteBooks(int id)
        {
            r.deleteBook(id);
            return StatusCode(200, "Book Deleted");
        }
    }
}
