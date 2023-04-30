using AcuiteCodingChallenge.Core.Entities;
using System.Collections.Generic;

namespace AcuiteCodingChallenge.ViewModels
{
    /// <summary>
    /// Model used by Index View
    /// </summary>
    public class IndexVm
    {
        public IEnumerable<Book> Books { get; set; }
        public Dictionary<string, string> FilterCategories { get; set; }
    }
}