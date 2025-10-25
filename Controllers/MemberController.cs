using LMS.Data;
using LMS.DataModel;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LMS.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _dbConn;

        public MemberController(ApplicationDbContext dbConn)
        {
            _dbConn = dbConn;
        }

        // GET: Member
        [HttpGet]
        public IActionResult Index()
        {
            // Retrieve all members from database
            var getData = _dbConn.Members.ToList();

            // Pass data to view (optional, if your view lists members)
            return View(getData);
        }

        // POST: Member
        [HttpPost]
        public IActionResult Index(MemberVM viewModel)
        {
            if (viewModel == null)
            {
                return View();
            }

            // Create new data model object
            var dataModel = new Member();

            // Map values from ViewModel to DataModel
            dataModel.MemberName = viewModel.MemberName;
            dataModel.MemberType = viewModel.MemberType;
            dataModel.Address = viewModel.Address;
            dataModel.PhoneNumber = viewModel.PhoneNumber;
            dataModel.Email = viewModel.Email;
            dataModel.JoinDate = viewModel.JoinDate;
            dataModel.ExpiryDate = viewModel.ExpiryDate;
            dataModel.Status = viewModel.Status;

            // Add record and save to database
            _dbConn.Members.Add(dataModel);
            _dbConn.SaveChanges();

            // Clear form fields after save
            ModelState.Clear();

            // Return the same view (you may redirect if preferred)
            return View(viewModel);
        }
    }
}
