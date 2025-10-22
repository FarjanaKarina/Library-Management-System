using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    public class FineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
