using BlazorIntro.Models;

namespace BlazorIntro.Services
{
    public class MyApi : IApiService
    {
        private HttpClient _http;
        public MyApi(HttpClient http)
        {
            _http = http;
        }
        public Task<TodoItem[]> GetTodos()
        {
            return _http.GetFromJsonAsync<TodoItem[]>(requestUri: "https://jsonplaceholder.typicode.com/todos");
        }
    }
}
