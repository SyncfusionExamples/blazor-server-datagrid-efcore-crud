using BlazorWebApp.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Services
{
    public class ClientServices
    {
        private readonly HttpClient _httpClient;

        public ClientServices ( HttpClient httpClient )
        {
            _httpClient = httpClient;

        }

        public async Task<List<Book>> GetBooks ()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Book>>("https://localhost:7105/api/DataGrid");

            return result;
        }


        public async Task<Book> InsertBook ( Book value )
        {
            await _httpClient.PostAsJsonAsync<Book>($"https://localhost:7105/api/DataGrid/", value);
            return value;
        }
        public async Task<bool> RemoveBook ( long bookId )
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"https://localhost:7105/api/DataGrid/{bookId}");

            return true;
        }

        public async Task<Book> UpdateBook ( long bookId, Book updatedBook )
        {
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"https://localhost:7105/api/DataGrid/{bookId}", updatedBook);

            return updatedBook;

        }
    }
}
