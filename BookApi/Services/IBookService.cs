using System;
using System.Collections.Generic;

namespace BookApi.Services
{
    public interface IBookService
    {

        IEnumerable<Book> GetBooks();
        Book GetBook(int Id);
        Book AddBook(Book newBook);
        Book ModifyBook(Book editBook);
        void DeleteBook(int Id);
    }
}
