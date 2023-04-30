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
	/// <summary>
	/// Book Service. Get books using web api endpoint
	/// </summary>
    public class BookServices : IBookServices
	{
		readonly string BaseUrl = WebConfigurationManager.AppSettings["ApiBaseUrl"];
		readonly MediaTypeWithQualityHeaderValue mediaType = new MediaTypeWithQualityHeaderValue("application/json");

		/// <summary>
		/// Get all books
		/// </summary>
		/// <returns>List of books</returns>
		public async Task<IEnumerable<Book>> GetAll() => await GetBooks("api/book");

		/// <summary>
		/// Get all books by category
		/// </summary>
		/// <param name="category">category</param>
		/// <returns>List of books</returns>
		public async Task<IEnumerable<Book>> GetBooksByCategory(string category) => await GetBooks($"api/book/category/{category}");

		/// <summary>
		/// Get all books by book title
		/// </summary>
		/// <param name="title">book title</param>
		/// <returns>List of books</returns>
		public async Task<IEnumerable<Book>> GetBooksByTitle(string title) => await GetBooks($"api/book/title/{title}");

		/// <summary>
		/// Get all books by Author name
		/// </summary>
		/// <param name="author">author name</param>
		/// <returns>List of books</returns>
		public async Task<IEnumerable<Book>> GetBooksByAuthor(string author) => await GetBooks($"api/book/author/{author}");

		/// <summary>
		/// Common function using httpClient
		/// </summary>
		/// <param name="endpoint">external endpoint</param>
		/// <returns>List of books</returns>
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