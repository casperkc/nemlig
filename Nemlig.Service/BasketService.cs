using System.Text;
using System.Text.Json;

public class BasketService
	{
        private readonly HttpClient client;

        public BasketService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<BasketModel> Add(string productId, string quantity)
        {
            try
            {
                dynamic product = new { productId = productId, quantity = quantity };

                var json = JsonSerializer.Serialize(product);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("webapi/basket/AddToBasket", content);

                if (response.IsSuccessStatusCode)
                {
                    var body = await response.Content.ReadAsStringAsync();

                    var result = JsonSerializer.Deserialize<BasketModel>(body);

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

        public async Task<bool> Clear()
        {
            try
            {
                var response = await client.PostAsync("webapi/basket/ClearBasket", null);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }
	}