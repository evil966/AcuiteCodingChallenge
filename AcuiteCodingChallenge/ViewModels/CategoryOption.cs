using System.Collections.Generic;

namespace AcuiteCodingChallenge.ViewModels
{
    public static class CategoryOptions
    {
        public static List<string> Get()
        {
            return new List<string>()
            { 
                "Computer Science|ComputerScience",
                "Physics|Physics",
                "History|History",
                "Geography|Geography",
                "Travel|Travel",
                "Fiction|Fiction"
            };
        }
    }
}