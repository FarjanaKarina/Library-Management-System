using LMS.Data;
using LMS.DataModel;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LMS.Controllers
{
    public class BookIssueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookIssueController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookIssue/Index
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
        }
    }
}
