using System;
namespace BookApi.Models
{
    public class ServerResponse
    {
        public int StatusCode { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}
