using System.ComponentModel;

namespace AcuiteCodingChallenge.Core.Constants
{
	/// <summary>
	/// Book Category enum
	/// </summary>
    public enum BookCategory
	{
		[Description("Computer Science")]
		ComputerScience,
		Physics,
		History,
		Geography,
		Fiction,
		Travel
	}
}
