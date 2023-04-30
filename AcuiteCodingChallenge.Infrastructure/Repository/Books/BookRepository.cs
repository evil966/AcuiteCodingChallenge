using AcuiteCodingChallenge.Core.Constants;
using AcuiteCodingChallenge.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcuiteCodingChallenge.Infrastructure.Repository.Books
{
    public class BookRepository : IRepository<Book>
	{
		private readonly List<Book> _data;

		public BookRepository()
		{
			_data = new List<Book>
			{
				new Book
				{
					Id = 1,
					Title = "Computer Science For Dummies",
					Author = "Joe Bloggs",
					Category = BookCategory.ComputerScience
				},
				new Book
				{
					Id = 2,
					Title = "Computer Science For Experts",
					Author = "Jane Doe",
					Category = BookCategory.ComputerScience
				},
				new Book
				{
					Id = 3,
					Title = "Introduction to Black Holes",
					Author = "Stephen Hawking",
					Category = BookCategory.Physics
				},
				new Book
				{
					Id = 4,
					Title = "World War 1",
					Author = "James Martin",
					Category = BookCategory.History
				},
				new Book
				{
					Id = 5,
					Title = "World War 2",
					Author = "James Martin",
					Category = BookCategory.History
				},
				new Book
				{
					Id = 6,
					Title = "Ternary Operators And When Not To Use Them",
					Author = "Anne Potter",
					Category = BookCategory.ComputerScience
				},
				new Book
				{
					Id = 7,
					Title = "Geography Rocks!",
					Author = "Martin Prince",
					Category = BookCategory.Geography
				},
				new Book
				{
					Id = 8,
					Title = "I am not a robot",
					Author = "Rob Otterman",
					Category = BookCategory.ComputerScience
				},
				new Book
				{
					Id = 9,
					Title = "New Zealand: Why Not?",
					Author = "Murray Hewitt",
					Category = BookCategory.Travel
				},
				new Book
				{
					Id = 10,
					Title = "JavaScript for Dummies",
					Author = "Bob Smith",
					Category = BookCategory.ComputerScience
				}
			};
		}

		public IEnumerable<Book> GetAll()
		{
			return _data;
		}

		public IEnumerable<Book> Get(Func<Book, bool> predicate)
		{
			return _data.Where(predicate);
		}
	}
}
