using NewsApp.MVVM.Model;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace NewsApp.Services
{
    public class MockNewsService
    {
        List<News> newsList = new List<News>()
        {
            new News()
            {
                Id = 1,
                Title = "Test 1",
                Content="Content Test 1.Content Test 1.Content Test 1.Content Test 1.Content Test 1.Content Test 1",
                ImageUrl="https://i.imghippo.com/files/HXjC3621cYg.webp"
            },
            new News()
            {
                Id = 2,
                Title = "Test 2",
                Content="Content Test 2.Content Test 2.Content Test 2.Content Test 2.Content Test 2.Content Test 2",
                ImageUrl="https://i.imghippo.com/files/DFk1901nZM.jpg"
            }
        };


        public List<News> GetNews()
        {
            return newsList;
        }
    }

    public class NewsService
    {
        List<News> newsList = new();
        HttpClient httpClient;
        public NewsService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<News>> GetNews()
        {

            var url = "https://mocki.io/v1/8cf5e925-e2ae-4ace-ae08-1421fa5bd127";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                newsList = await response.Content.ReadFromJsonAsync<List<News>>();
            }

            return newsList;
        }
    }
}
