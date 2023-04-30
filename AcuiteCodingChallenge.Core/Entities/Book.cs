using AcuiteCodingChallenge.Core.Constants;

namespace AcuiteCodingChallenge.Core.Entities
{
	/// <summary>
	/// Book poco
	/// </summary>
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public BookCategory Category { get; set; }
	}
}
