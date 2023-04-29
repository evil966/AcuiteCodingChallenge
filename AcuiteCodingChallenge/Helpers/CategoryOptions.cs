using AcuiteCodingChallenge.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcuiteCodingChallenge.Helpers
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