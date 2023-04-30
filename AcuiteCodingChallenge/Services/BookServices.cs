using AcuiteCodingChallenge.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace AcuiteCodingChallenge.Services
{
    public class BookServices : IBookServices
	{
		readonly string BaseUrl = WebConfigurationManager.AppSettings["ApiBaseUrl"];
		readonly MediaTypeWithQualityHeaderValue mediaType = new MediaTypeWithQualityHeaderValue("application/json");

		public async Task<IEnumerable<Book>> GetAll() => await GetBooks("api/book");

		public async Task<IEnumerable<Book>> GetBooksByCategory(string category) => await GetBooks($"api/book/category/{category}");

		public async Task<IEnumerable<Book>> GetBooksByTitle(string title) => await GetBooks($"api/book/title/{title}");

		public async Task<IEnumerable<Book>> GetBooksByAuthor(string author) => await GetBooks($"api/book/author/{author}");

		private async Task<IEnumerable<Book>> GetBooks(string endpoint)
		{
			var books = new List<Book>();
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(BaseUrl);
				client.DefaultRequestHeaders.Clear();
				client.DefaultRequestHeaders.Accept.Add(mediaType);
				HttpResponseMessage response = await client.GetAsync(endpoint);
				if (response.IsSuccessStatusCode)
				{
					var booksResponse = response.Content.ReadAsStringAsync().Result;
					books = JsonConvert.DeserializeObject<List<Book>>(booksResponse);
				}
			}

			return books;
		}
	}
}