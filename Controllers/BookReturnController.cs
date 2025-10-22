using LMS.Data;
using LMS.DataModel;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class BookReturnController : Controller
    {
        private readonly ApplicationDbContext _dbConn;

        public BookReturnController(ApplicationDbContext dbConn)
        {
            _dbConn = dbConn;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var getdata = _dbConn.BookReturns.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Index(BookReturnVM viewModel)
        {
            var dataModel = new BookReturn();
            dataModel.MemberName = viewModel.MemberName;
            dataModel.BookTitle = viewModel.BookTitle;
            dataModel.IssueDate = viewModel.IssueDate;
            dataModel.ReturnDate = viewModel.ReturnDate;
            dataModel.FineAmount = viewModel.FineAmount;
            dataModel.Status = viewModel.Status;


            _dbConn.BookReturns.Add(dataModel);
            _dbConn.SaveChanges();

            return View(viewModel);
        }
    }
}
