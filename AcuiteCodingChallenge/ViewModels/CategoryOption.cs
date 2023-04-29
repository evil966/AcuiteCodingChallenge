using AcuiteCodingChallenge.Core.Constants;
using System.Collections.Generic;

namespace AcuiteCodingChallenge.ViewModels
{
    public static class CategoryOptions
    {
        public static Dictionary<string, string> Get()
        {
            return new Dictionary<string, string>
            {
                { "Computer Science", BookCategory.ComputerScience.ToString() },
                { "Physics", BookCategory.Physics.ToString() },
                { "History", BookCategory.History.ToString() },
                { "Geography", BookCategory.Geography.ToString() },
                { "Travel", BookCategory.Travel.ToString() },
                { "Fiction", BookCategory.Fiction.ToString() }
            };
        }
    }
}