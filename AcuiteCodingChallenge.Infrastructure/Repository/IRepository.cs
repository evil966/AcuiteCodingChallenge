using System;
using System.Collections.Generic;

namespace AcuiteCodingChallenge.Infrastructure.Repository
{
    public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		IEnumerable<T> Get(Func<T, bool> predicate);
	}
}
