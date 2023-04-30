using AcuiteCodingChallenge.Core.Entities;
using AcuiteCodingChallenge.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AcuiteCodingChallenge.Api.Controllers
{
    /// <summary>
    /// Book Controller
    /// </summary>
    public class BookController : ApiController
    {
        private readonly IRepository<Book> _repository;

        public BookController(IRepository<Book> repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Get all books
        /// </summary>
        /// <returns>list of books</returns>
        public IEnumerable<Book> Get() => _repository.GetAll();

        /// <summary>
        /// Get list of books by Category
        /// </summary>
        /// <param name="id">category name</param>
        /// <returns>list of books</returns>
        [HttpGet]
        [ActionName("category")]
        public IEnumerable<Book> GetCategory(string id) => _repository.Get((b) => b.Category.ToString().Equals(id, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        /// Get list of books by title
        /// </summary>
        /// <param name="id">title name</param>
        /// <returns>list of books</returns>
        [HttpGet]
        [ActionName("title")]
        public IEnumerable<Book> GetBooksByTitle(string id) => _repository.Get((b) => b.Title.ToLower().Contains(id.ToLower()));

        /// <summary>
        /// Get list of books by author name
        /// </summary>
        /// <param name="id">author name</param>
        /// <returns>list of books</returns>
        [HttpGet]
        [ActionName("author")]
        public IEnumerable<Book> GetBooksByAuthor(string id) => _repository.Get((b) => b.Author.ToLower().Contains(id.ToLower()));

    }
}
