using BlazorIntro.Models;
using System.Net.Http.Json;
using static BlazorIntro.Pages.Todo;
using static System.Net.WebRequestMethods;

namespace BlazorIntro.Services
{
    public class JsonPlaceHolderApi:IApiService
    {
        private HttpClient _http;
        public JsonPlaceHolderApi(HttpClient http)
        {
            _http = http;
        }
        public Task<TodoItem[]> GetTodos()
        {
            return _http.GetFromJsonAsync<TodoItem[]>(requestUri: "https://jsonplaceholder.typicode.com/todos");
        }
    }
}
