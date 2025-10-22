using LMS.Data;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _dbConn;

        public BookController(ApplicationDbContext dbConn)
        {
            _dbConn = dbConn;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BookVM viewModel)
        {
            return View(viewModel);
        }
    }
}
