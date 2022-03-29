using System;
using System.Collections.Generic;
using BookApi.Data;

namespace BookApi.Services
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;
        public BookService(DataContext context)
        {
            _context = context;
        }

        public Book AddBook(Book newBook)
        {
            
            throw new NotImplementedException();
        }

        public void DeleteBook(int Id)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Book ModifyBook(Book editBook)
        {
            throw new NotImplementedException();
        }
    }
}
