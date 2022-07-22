using BookSystem.Data;
using BookSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSystem.Repository
{
    public class BookRepo : IBook
    {
        private BookDbContext DbContext;
        public BookRepo(BookDbContext bookDbContext)
        {
            DbContext = bookDbContext;
        }
        public string DeleteBook(int BookId)
        {
            string msg = string.Empty;
            Book delete = DbContext.book.Find(BookId);
            if (delete != null)
            {
                DbContext.book.Remove(delete);
                DbContext.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = DbContext.book.ToList();
            return books;
            
        }

        public Book GetBook(int BookId)
        {
            Book book = DbContext.book.Find(BookId);
            return book;
            
        }

        public string SaveBook(Book book)
        {
            DbContext.book.Add(book);
            DbContext.SaveChanges();
            return "Added Successfully";
        }

        public string UpdateBook(Book book)
        {
            DbContext.Entry(book).State = EntityState.Modified; // modify the state in which the model is
            DbContext.SaveChanges();
            return "Updated";
            
        }
    }
}
