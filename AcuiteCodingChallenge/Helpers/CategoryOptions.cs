using AcuiteCodingChallenge.Core.Constants;
using System.Collections.Generic;

namespace AcuiteCodingChallenge.Helpers
{
    /// <summary>
    /// Helper functions for Categories used in select options
    /// </summary>
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