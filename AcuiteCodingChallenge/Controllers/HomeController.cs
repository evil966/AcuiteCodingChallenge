using AcuiteCodingChallenge.Helpers;
using AcuiteCodingChallenge.Services;
using AcuiteCodingChallenge.ViewModels;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AcuiteCodingChallenge.Controllers
{
	/// <summary>
	/// Home Controller
	/// </summary>
    public class HomeController : Controller
	{
		private readonly IndexVm _model;
		private readonly IBookServices _service;
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="service">injected service</param>
		public HomeController(IBookServices service)
		{
			_service = service;
			_model = new IndexVm
            {
                FilterCategories = CategoryOptions.Get()
            };
			ViewBag.Title = "Home";
		}

		/// <summary>
		/// default route
		/// </summary>
		/// <returns>List of books</returns>
		public async Task<ActionResult> Index()
		{
			_model.Books = await _service.GetAll();
			return View(_model);
		}

		/// <summary>
		/// Get all books
		/// </summary>
		/// <returns>List of books</returns>
		[HttpGet]
		[ActionName("all")]
		public async Task<ActionResult> GetAllBooks()
		{
			var books = await _service.GetAll();
			return PartialView("_BookListView", books);
		}

		/// <summary>
		/// Get list of books by category
		/// </summary>
		/// <param name="category"></param>
		/// <returns>List of books</returns>
		[HttpGet]
		[ActionName("category")]
		public async Task<ActionResult> BooksByCategory(string category)
		{
			var books = await _service.GetBooksByCategory(category);
			return PartialView("_BookListView", books);
		}

		/// <summary>
		/// Get list of books by book title
		/// </summary>
		/// <param name="searchBy">search term</param>
		/// <returns>List of books</returns>
		[HttpGet]
		[ActionName("title")]
		public async Task<ActionResult> BooksByTitle(string searchBy)
		{
			var books = await _service.GetBooksByTitle(searchBy);
			return PartialView("_BookListView", books);
		}

		/// <summary>
		/// Get list of book by author
		/// </summary>
		/// <param name="searchBy">search term</param>
		/// <returns>List of books</returns>
		[HttpGet]
		[ActionName("author")]
		public async Task<ActionResult> BooksByAuthor(string searchBy)
		{
			var books = await _service.GetBooksByAuthor(searchBy);
			return PartialView("_BookListView", books);
		}

	}
}