using System;
using System.Collections.Generic;

namespace AcuiteCodingChallenge.Infrastructure.Repository
{
	/// <summary>
	/// Repository Interface signature used by BookRepository and
	/// can also be used by other with similar structure.
	/// </summary>
	/// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		IEnumerable<T> Get(Func<T, bool> predicate);
	}
}
