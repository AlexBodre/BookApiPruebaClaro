using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BookApi.Models;

namespace BookApi.Services
{
    public class BookService : IBookService
    {
        private string baseUrl = "https://fakerestapi.azurewebsites.net/api/";
        private readonly HttpClient client;
        
        public BookService()
        {
           client = new HttpClient();

           client.BaseAddress = new Uri(baseUrl);
        }

        public async Task<ServerResponse> GetBooks()
        {
            var response = await client.GetAsync($"v1/Books");
            var serviceStatusCode = (int)response.StatusCode;
            var responseData = serviceStatusCode == 200 ? await response.Content.ReadFromJsonAsync<List<Book>>() : null;

            return new ServerResponse {
                StatusCode = serviceStatusCode,
                Data = responseData,
                Message = serviceStatusCode == 200 ? "OK" : "Error al obtener libros"
            };
        }

        public async Task<ServerResponse> GetBook(int Id)
        {

            var response = await client.GetAsync($"v1/Books/{Id}");
            var serviceStatusCode = (int)response.StatusCode;
            var responseData = serviceStatusCode == 200 ? await response.Content.ReadFromJsonAsync<Book>() : null;
           

            return new ServerResponse
            {
                StatusCode = serviceStatusCode,
                Data = responseData,
                Message = serviceStatusCode == 200 ? "OK" : "Error al obtener libro"
            };
        }

        public async Task<ServerResponse> AddBook(Book newBook)
        {
            var response = await client.PostAsJsonAsync("v1/Books", newBook);
            var serviceStatusCode = (int)response.StatusCode;
            var responseData = serviceStatusCode == 200 ? await response.Content.ReadFromJsonAsync<Book>() : null;
           

            return new ServerResponse
            {
                StatusCode = serviceStatusCode,
                Data = responseData,
                Message = serviceStatusCode == 200 ? "OK" : "Error al agregar libro"
            };
        }

        public async Task<ServerResponse> ModifyBook(int Id, Book editBook)
        {
            var response = await client.PutAsJsonAsync($"v1/Books/{Id}", editBook);
            var serviceStatusCode = (int)response.StatusCode;
            var responseData = serviceStatusCode == 200 ? await response.Content.ReadFromJsonAsync<Book>() : null;

            return new ServerResponse
            {
                StatusCode = serviceStatusCode,
                Data = responseData,
                Message = serviceStatusCode == 200 ? "OK" : "Error al modificar libro"
            };
        }

        public async Task<ServerResponse> DeleteBook(int Id)
        {
            var response = await client.DeleteAsync($"v1/Books/{Id}");
            var serviceStatusCode = (int)response.StatusCode;
            var responseData = serviceStatusCode == 200 ? "Success" : null;
           
            return new ServerResponse
            {
                StatusCode = serviceStatusCode,
                Data = responseData,
                Message = serviceStatusCode == 200 ? "OK" : "Error al borrar libro"
            };
        }
    }
}
