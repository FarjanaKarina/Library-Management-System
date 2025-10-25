using LMS.Data;
using LMS.DataModel;
using LMS.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace LMS.Controllers
{
    public class FineController : Controller
    {
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
        }
    }
}
