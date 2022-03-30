using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookApi.Models;

namespace BookApi.Services
{
    public interface IBookService
    {

        Task<ServerResponse> GetBooks();
        Task<ServerResponse> GetBook(int Id);
        Task<ServerResponse> AddBook(Book newBook);
        Task<ServerResponse> ModifyBook(int Id, Book editBook);
        Task<ServerResponse> DeleteBook(int Id);
    }
}
