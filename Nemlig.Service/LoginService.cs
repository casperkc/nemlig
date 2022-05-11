using System.Text;
using System.Text.Json;

public class LoginService
    {
        private HttpClient client;

        public LoginService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<LoginModel?> Login(string username, string password)
        {
            try
            {
                var credentials = new Credentials(username, password);

                var json = JsonSerializer.Serialize(credentials);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("webapi/login/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();

                    var result = JsonSerializer.Deserialize<LoginModel>(body);

                    if (result is not null)
                    {
                        return result;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }
    }
