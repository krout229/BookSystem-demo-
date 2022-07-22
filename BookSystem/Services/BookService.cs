using BookSystem.Models;
using BookSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSystem.Services
{
    public class BookService
    {
        private IBook _Ibook;
        public BookService(IBook Ibook)
        {
            _Ibook = Ibook;
        }
        public string SaveBook(Book book)
        {
            return _Ibook.SaveBook(book);
        }
        public string UpdateBook(Book book)
        {
            return _Ibook.UpdateBook(book);
        }
        public string DeleteBook(int BookId)
        {
            return _Ibook.DeleteBook(BookId);

        }
        public Book GetBook(int BookId)
        {
            return _Ibook.GetBook(BookId);
        }
        public List<Book> GetAllBooks()
        {
            return _Ibook.GetAllBooks();
        }
    }
}
