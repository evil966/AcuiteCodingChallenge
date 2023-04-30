using AcuiteCodingChallenge.Core.Entities;
using AcuiteCodingChallenge.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AcuiteCodingChallenge.Api.Controllers
{
    public class BookController : ApiController
    {
        private readonly IRepository<Book> _repository;

        public BookController(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Book> Get() => _repository.GetAll();

        [HttpGet]
        [ActionName("category")]
        public IEnumerable<Book> GetCategory(string id) => _repository.Get((b) => b.Category.ToString().Equals(id, StringComparison.OrdinalIgnoreCase));

        [HttpGet]
        [ActionName("title")]
        public IEnumerable<Book> GetBooksByTitle(string id) => _repository.Get((b) => b.Title.ToLower().Contains(id.ToLower()));

        [HttpGet]
        [ActionName("author")]
        public IEnumerable<Book> GetBooksByAuthor(string id) => _repository.Get((b) => b.Author.ToLower().Contains(id.ToLower()));

    }
}
