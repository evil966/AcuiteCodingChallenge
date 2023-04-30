using AcuiteCodingChallenge.Helpers;
using AcuiteCodingChallenge.Services;
using AcuiteCodingChallenge.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AcuiteCodingChallenge.Controllers
{
    public class HomeController : Controller
	{
		private readonly IndexVm _model;
		
		public HomeController()
		{
			_model = new IndexVm
            {
                FilterCategories = CategoryOptions.Get()
            };
			ViewBag.Title = "Home";
		}

		public async Task<ActionResult> Index()
		{
			_model.Books = await BookServices.GetAll();
			return View(_model);
		}

		[HttpGet]
		[ActionName("all")]
		public async Task<ActionResult> GetAllBooks()
		{
			var books = await BookServices.GetAll();
			return PartialView("_BookListView", books);
		}

		[HttpGet]
		[ActionName("category")]
		public async Task<ActionResult> BooksByCategory(string category)
		{
			var books = await BookServices.GetBooksByCategory(category);
			return PartialView("_BookListView", books);
		}

		[HttpGet]
		[ActionName("title")]
		public async Task<ActionResult> BooksByTitle(string searchBy)
		{
			var books = await BookServices.GetBooksByTitle(searchBy);
			return PartialView("_BookListView", books);
		}

		[HttpGet]
		[ActionName("author")]
		public async Task<ActionResult> BooksByAuthor(string searchBy)
		{
			var books = await BookServices.GetBooksByAuthor(searchBy);
			return PartialView("_BookListView", books);
		}

	}
}