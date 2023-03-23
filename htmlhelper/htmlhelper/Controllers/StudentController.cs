using Microsoft.AspNetCore.Mvc;

namespace htmlhelper.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
