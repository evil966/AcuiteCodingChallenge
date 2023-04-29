using AcuiteCodingChallenge.Services;
using AcuiteCodingChallenge.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AcuiteCodingChallenge.Controllers
{
    public class HomeController : Controller
	{
		public HomeController()
		{
			this.ViewBag.Title = "Home";
			this.ViewBag.Categories = CategoryOptions.Get();
		}

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
		[ActionName("title")]
		public async Task<ActionResult> BooksByTitle(string searchBy)
		{
			var books = await BookServices.GetBooksByTitle(searchBy);
			return PartialView("Index", books);
		}

		[HttpGet]
		[ActionName("author")]
		public async Task<ActionResult> BooksByAuthor(string searchBy)
		{
			var books = await BookServices.GetBooksByAuthor(searchBy);
			return PartialView("Index", books);
		}

	}
}