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
		[ActionName("category")]
		public async Task<ActionResult> BooksByCategory(string category)
		{
			var books = await BookServices.GetBooksByCategory(category);
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("search")]
		public async Task<ActionResult> BooksByTitle(string searchBy)
		{
			var books = await BookServices.GetBooksByTitle(searchBy);
			return PartialView("Index", books);
		}

	}
}