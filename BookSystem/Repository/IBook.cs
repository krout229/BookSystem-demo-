using BookSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSystem.Repository
{
    public interface IBook
    {
        public string SaveBook(Book book);
        public string UpdateBook(Book book);
        public string DeleteBook(int BookId);
        Book GetBook(int BookId);
        List<Book> GetAllBooks();
    }
}
