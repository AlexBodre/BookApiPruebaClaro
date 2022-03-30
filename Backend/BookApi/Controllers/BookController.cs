using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class BookController : Controller
    {
        
        public readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet, Route("Books")]
        public async Task<IActionResult> Get()
        {
            var response = await _bookService.GetBooks();
            return StatusCode(response.StatusCode, response);
        }
        [HttpGet, Route("Books/{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            var response = await _bookService.GetBook(Id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost, Route("Books")]
        public async Task<IActionResult> Post(Book newBook)
        {
            var response = await _bookService.AddBook(newBook);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPut, Route("Books/{Id}")]
        public async Task<IActionResult> Put(int Id, [FromBody] Book editBook)
        {
            var response = await _bookService.ModifyBook(Id, editBook);
            return StatusCode(response.StatusCode, response);
        }

        [HttpDelete, Route("Books/{Id}")]
        public async Task<IActionResult>Delete(int Id)
        {
            var response = await _bookService.DeleteBook(Id);
            return StatusCode(response.StatusCode, response);
        }
    }
}
