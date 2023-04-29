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
			_model.Books = await BookServices.GetAll();
			return PartialView("Index", _model);
		}

		[HttpGet]
		[ActionName("category")]
		public async Task<ActionResult> BooksByCategory(string category)
		{
			_model.Books = await BookServices.GetBooksByCategory(category);
			return PartialView("Index", _model);
		}

		[HttpGet]
		[ActionName("title")]
		public async Task<ActionResult> BooksByTitle(string searchBy)
		{
			_model.Books = await BookServices.GetBooksByTitle(searchBy);
			return PartialView("Index", _model);
		}

		[HttpGet]
		[ActionName("author")]
		public async Task<ActionResult> BooksByAuthor(string searchBy)
		{
			_model.Books = await BookServices.GetBooksByAuthor(searchBy);
			return PartialView("Index", _model);
		}

	}
}