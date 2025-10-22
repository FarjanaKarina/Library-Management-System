using LMS.Data;
using LMS.DataModel;
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
            var getdata = _dbConn.Books.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Index(BookVM viewModel)
        {
            var dataModel = new Book();
            
                dataModel.Title = viewModel.Title;
                dataModel.Author = viewModel.Author;
                dataModel.Publisher = viewModel.Publisher;
                dataModel.Category = viewModel.Category;
                dataModel.PurchaseDate = viewModel.PurchaseDate;
                dataModel.Price = viewModel.Price;
                dataModel.Quantity = viewModel.Quantity;
                dataModel.Status = viewModel.Status;
           
            _dbConn.Books.Add(dataModel);
            _dbConn.SaveChanges();

            return View(viewModel);
        }
    }
}
