using AcuiteCodingChallenge.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AcuiteCodingChallenge.Services
{
    /// <summary>
    /// Book Services Interface
    /// </summary>
    public interface IBookServices
    {
        Task<IEnumerable<Book>> GetAll();
        Task<IEnumerable<Book>> GetBooksByCategory(string category);
        Task<IEnumerable<Book>> GetBooksByTitle(string title);
        Task<IEnumerable<Book>> GetBooksByAuthor(string author);

    }
}
