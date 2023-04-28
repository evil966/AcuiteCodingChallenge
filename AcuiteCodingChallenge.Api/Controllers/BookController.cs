﻿using AcuiteCodingChallenge.Entities;
using AcuiteCodingChallenge.Repository.Context;
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
        [ActionName("Category")]
        public IEnumerable<Book> GetCategory(string id) => _repository.Get((b) => b.Category.ToString().Equals(id, StringComparison.OrdinalIgnoreCase));

        [HttpGet]
        [ActionName("Title")]
        public IEnumerable<Book> GetBooksByTitle(string id) => _repository.Get((b) => b.Title.ToLower().Contains(id.ToLower()));

        [HttpGet]
        [ActionName("Author")]
        public IEnumerable<Book> GetBooksByAuthor(string id) => _repository.Get((b) => b.Author.ToLower().Contains(id.ToLower()));

    }
}
