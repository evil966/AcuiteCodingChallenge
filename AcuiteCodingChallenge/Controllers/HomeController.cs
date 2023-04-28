using AcuiteCodingChallenge.Services;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AcuiteCodingChallenge.Controllers
{
    public class HomeController : Controller
	{
		public async Task<ActionResult> Index()
		{
			var books = await BookServices.GetAll();
			return View(books);
		}

		[HttpGet]
		[ActionName("all")]
		public async Task<ActionResult> GetAllBooks()
		{
			var books = await BookServices.GetAll();
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("physics")]
		public async Task<ActionResult> BooksByCategoryPhysics()
		{
			var books = await BookServices.GetBooksByCategory("Physics");
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("cs")]
		public async Task<ActionResult> BooksByCategoryCS()
		{
			var books = await BookServices.GetBooksByCategory("ComputerScience");
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("history")]
		public async Task<ActionResult> BooksByCategoryHistory()
		{
			var books = await BookServices.GetBooksByCategory("History");
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("geography")]
		public async Task<ActionResult> BooksByCategoryGeography()
		{
			var books = await BookServices.GetBooksByCategory("Geography");
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("travel")]
		public async Task<ActionResult> BooksByCategoryFiction()
		{
			var books = await BookServices.GetBooksByCategory("Travel");
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("title")]
		public async Task<ActionResult> BooksByTitle(string title)
		{
			var books = await BookServices.GetBooksByTitle(title);
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("author")]
		public async Task<ActionResult> BooksByAuthor(string author)
		{
			var books = await BookServices.GetBooksByAuthor(author);
			return PartialView("Index", books);
		}

	}
}