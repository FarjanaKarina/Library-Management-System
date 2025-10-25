using LMS.Data;
using LMS.DataModel;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class BookIssueController : Controller
    {
        private readonly ApplicationDbContext _dbConn;

        public BookIssueController(ApplicationDbContext dbConn)
        {
            _dbConn = dbConn;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(BookIssueVM viewModel)
        {
            var dataModel = new BookIssue();

            // Map fields from ViewModel to DataModel
            dataModel.MemberName = viewModel.MemberName;
            dataModel.BookId = viewModel.BookId;
            dataModel.IssueDate = viewModel.IssueDate;
            dataModel.DueDate = viewModel.DueDate;
            dataModel.ReturnDate = viewModel.ReturnDate;  // can be null
            dataModel.FineAmount = viewModel.FineAmount;

            // Save to database
            _dbConn.BookIssues.Add(dataModel);
            _dbConn.SaveChanges();

            // Optionally clear form after save
            ModelState.Clear();
            return View(viewModel);
        }
    }
}
