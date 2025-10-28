using LMS.Data;
using LMS.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LMS.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.Members.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Member member)
        {
            member.MemberId = Guid.NewGuid();
            _db.Members.Add(member);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
