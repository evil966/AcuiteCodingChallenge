using System;
using System.Collections.Generic;

namespace AcuiteCodingChallenge.Repository.Context
{
    public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();
		IEnumerable<T> Get(Func<T, bool> predicate);
	}
}
