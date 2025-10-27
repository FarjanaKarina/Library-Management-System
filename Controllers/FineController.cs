using LMS.Data;
using LMS.DataModel;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LMS.Controllers
{
    public class FineController : Controller
    {
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
