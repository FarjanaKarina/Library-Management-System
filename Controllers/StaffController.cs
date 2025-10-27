using LMS.Data;
using LMS.DataModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace LMS.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StaffController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var data = _db.Staffs.ToList();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Staff staff)
        {
            staff.StaffId = Guid.NewGuid();
            _db.Staffs.Add(staff);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
