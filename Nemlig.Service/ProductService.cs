using System.Text.Json;

public class ProductService
	{
		private readonly HttpClient client;

		public ProductService(HttpClient client)
		{
			this.client = client;
		}

		public async Task<Product[]> Query(string query, int take = 20, int skip = 0)
        {
            try
            {
				var response = await client.GetAsync($"webapi/s/0/1/0/Search/Search?query={query}&take={take}&skip={skip}");

				if (response.IsSuccessStatusCode)
				{
					var body = await response.Content.ReadAsStringAsync();

					var result = JsonSerializer.Deserialize<ProductModel>(body);

                    if (result is not null)
                    {
						return result.ProductResults.Products;
					}
				}

				return Array.Empty<Product>();
			}
            catch (Exception ex)
            {
				throw new HttpRequestException(ex.Message);
			}
		}
	}