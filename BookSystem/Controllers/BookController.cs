using BookSystem.Models;
using BookSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookService _bookService;
        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }
        
        [HttpPost("SaveBook")]
        public IActionResult SaveBook(Book book)
        {
            return Ok(_bookService.SaveBook(book));
        }
        [HttpPut("UpdateBook")]
        public IActionResult UpdateBook(Book book)
        {
            return Ok(_bookService.UpdateBook(book));
        }
        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(int BookId)
        {
            return Ok(_bookService.DeleteBook(BookId));
        }
        [HttpGet("GetBook")]
        public IActionResult GetBook(int BookId)
        {
            return Ok(_bookService.GetBook(BookId));
        }
        [HttpGet("GetAllBooks")]
        public  List<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }
    }
}
