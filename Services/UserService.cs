namespace FullStackDevWeek2.Services
{
    using System.Text.Json;

    public class UserService : IUserService
    {

        public async Task<List<Models.User>> GetUsersAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<IEnumerable<Models.User>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return users.ToList();
            }
        }



        public async Task<Models.User> GetUserByIdAsync(int id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync($"https://jsonplaceholder.typicode.com/users/{id}");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<Models.User>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return user;
            }
        }

    }
}
