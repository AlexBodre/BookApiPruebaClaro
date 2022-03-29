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
            if (response == null)
                return StatusCode(500, "Error al obtener libros");

            return Ok(response);
        }
        [HttpGet, Route("Books/{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            var response = await _bookService.GetBook(Id);
            if (response == null)
                return StatusCode(500, "Error al obtener libro");

            return Ok(response);
        }

        [HttpPost, Route("Books")]
        public async Task<IActionResult> Post(Book newBook)
        {
            var response = await _bookService.AddBook(newBook);
            if (response == null)
                return StatusCode(500, "Error al agregar libro");

            return Ok(response);
        }

        [HttpPut, Route("Books/{Id}")]
        public async Task<IActionResult> Put(Book editBook)
        {
            var response = await _bookService.ModifyBook(editBook);
            if (response == null)
                return StatusCode(500, "Error al editar libro");

            return Ok(response);
        }

        [HttpDelete, Route("Books/{Id}")]
        public async Task<IActionResult>Delete(int Id)
        {
            var response = await _bookService.DeleteBook(Id);
            if (response == null)
                return StatusCode(500, "Error al borrar libro");

            return Ok(response);
        }
    }
}
