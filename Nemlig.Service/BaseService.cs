using System;
using System.Net;

namespace Nemlig.Service
{
	public class BaseService
	{
		public HttpClient client;

		public BaseService()
		{
			HttpClientHandler clientHandler = new HttpClientHandler();
			clientHandler.UseCookies = true;
			clientHandler.CookieContainer = new CookieContainer();

			client = new HttpClient(clientHandler)
			{
				BaseAddress = new Uri("https://www.nemlig.com/"),
				Timeout = new TimeSpan(0, 0, 30),
			};
		}
	}
}

