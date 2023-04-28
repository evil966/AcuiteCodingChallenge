using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace AcuiteCodingChallenge
{
	/* ** Please do not make any changes to this file **
	 * It is included as a very basic data access layer to faciliate the rest of the challenge without
	 * needing a database.
	 */

	public enum BookCategory
	{
		[Description("Computer Science")]
		ComputerScience,
		Physics,
		History,
		Geography,
		Fiction,
		Travel
	}

	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public BookCategory Category { get; set; }
	}

	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		IEnumerable<T> Get(Func<T, bool> predicate);
	}

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