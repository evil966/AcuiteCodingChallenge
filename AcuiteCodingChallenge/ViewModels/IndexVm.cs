using AcuiteCodingChallenge.Core.Entities;
using System.Collections.Generic;

namespace AcuiteCodingChallenge.ViewModels
{
    public class IndexVm
    {
        public IEnumerable<Book> Books { get; set; }
        public Dictionary<string, string> FilterCategories { get; set; }
    }
}