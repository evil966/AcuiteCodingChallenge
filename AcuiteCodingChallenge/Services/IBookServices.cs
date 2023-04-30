using AcuiteCodingChallenge.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcuiteCodingChallenge.Services
{
    public interface IBookServices
    {
        Task<IEnumerable<Book>> GetAll();
        Task<IEnumerable<Book>> GetBooksByCategory(string category);
        Task<IEnumerable<Book>> GetBooksByTitle(string title);
        Task<IEnumerable<Book>> GetBooksByAuthor(string author);

    }
}
