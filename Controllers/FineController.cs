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
    public class FineController : Controller
    {
<<<<<<< HEAD
        private readonly ApplicationDbContext _context;

        public FineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Fine/Index
        public IActionResult Index()
        {
            var data = from fine in _context.Fines
                       join issue in _context.BookIssues on fine.IssueId equals issue.IssueId
                       join book in _context.Books on issue.BookId equals book.BookId
                       join member in _context.Members on fine.MemberId equals member.MemberId
                       select new FineVM
                       {
                           FineId = fine.FineId,
                           MemberName = member.MemberName,
                           BookTitle = book.Title,
                           FineAmount = fine.FineAmount,
                           FineDate = fine.FineDate,
                           PaymentStatus = fine.PaymentStatus
                       };

            return View(data.ToList());
        }

        // GET: Fine/Create
        public IActionResult Create()
        {
            ViewBag.Members = _context.Members.ToList();
            ViewBag.BookIssues = _context.BookIssues.ToList();
            return View();
=======
        private readonly ApplicationDbContext _dbConn;

        public FineController(ApplicationDbContext dbConn)
        {
            _dbConn = dbConn;
        }

        // GET: Fine
        [HttpGet]
        public IActionResult Index()
        {
            // Get all fine records from the database
            var getData = _dbConn.Fines.ToList();

            // Pass the list to the view (if your view expects it)
            return View(getData);
        }

        // POST: Fine
        [HttpPost]
        public IActionResult Index(FineVM viewModel)
        {
            

            // Create a new DataModel object
            var dataModel = new Fine();

            // Map the fields from ViewModel to DataModel
            dataModel.MemberName = viewModel.MemberName;
            dataModel.DateIssued = viewModel.DateIssued;
            dataModel.FineAmount = viewModel.FineAmount;
            dataModel.FineDate = viewModel.FineDate;
            dataModel.PaymentStatus = viewModel.PaymentStatus;

            // Add and save the record to the database
            _dbConn.Fines.Add(dataModel);
            _dbConn.SaveChanges();

            // Clear form after save
            ModelState.Clear();

            // Return the same view (you can redirect to list view if preferred)
            return View(viewModel);
>>>>>>> 0d323f99f8dcd0d9e554e5f27dd629af1015fa09
        }

        // POST: Fine/Create
        [HttpPost]
        public IActionResult Create(Fine model)
        {
            if (model != null)
            {
                model.FineId = Guid.NewGuid();
                _context.Fines.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Members = _context.Members.ToList();
            ViewBag.BookIssues = _context.BookIssues.ToList();
            return View(model);
        }
    }
}
