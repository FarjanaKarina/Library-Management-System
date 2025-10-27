using LMS.Data;
using LMS.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LMS.Controllers
{
    public class BookReturnController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookReturnController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.BookReturns.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookReturn ret)
        {
            ret.ReturnId = Guid.NewGuid();
            _db.BookReturns.Add(ret);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
