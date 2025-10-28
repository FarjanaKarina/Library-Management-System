using LMS.Data;
using LMS.DataModel;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using System;
using System.Linq;
=======
>>>>>>> 0d323f99f8dcd0d9e554e5f27dd629af1015fa09

namespace LMS.Controllers
{
    public class BookIssueController : Controller
    {
<<<<<<< HEAD
        private readonly ApplicationDbContext _context;

        public BookIssueController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookIssue/Index
=======
        private readonly ApplicationDbContext _dbConn;

        public BookIssueController(ApplicationDbContext dbConn)
        {
            _dbConn = dbConn;
        }
        [HttpGet]
>>>>>>> 0d323f99f8dcd0d9e554e5f27dd629af1015fa09
        public IActionResult Index()
        {
            var data = from issue in _context.BookIssues
                       join book in _context.Books on issue.BookId equals book.BookId
                       join member in _context.Members on issue.MemberId equals member.MemberId
                       select new BookIssueVM
                       {
                           IssueId = issue.IssueId,
                           BookId = book.BookId,
                           MemberId = member.MemberId,
                           BookTitle = book.Title,
                           MemberName = member.MemberName,
                           IssueDate = issue.IssueDate,
                           DueDate = issue.DueDate,
                           ReturnDate = issue.ReturnDate,
                           FineAmount = issue.FineAmount
                       };

            return View(data.ToList());
        }

        // GET: BookIssue/Create
        public IActionResult Create()
        {
            ViewBag.Books = _context.Books.ToList();
            ViewBag.Members = _context.Members.ToList();
            return View();
        }
<<<<<<< HEAD

        // POST: BookIssue/Create
        [HttpPost]
        public IActionResult Create(BookIssue model)
        {
            if (model != null)
            {
                model.IssueId = Guid.NewGuid();
                _context.BookIssues.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Books = _context.Books.ToList();
            ViewBag.Members = _context.Members.ToList();
            return View(model);
=======
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
>>>>>>> 0d323f99f8dcd0d9e554e5f27dd629af1015fa09
        }
    }
}
