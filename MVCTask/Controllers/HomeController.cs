using Microsoft.AspNetCore.Mvc;
using MVCTask;
using System.Diagnostics;

namespace MVCTask.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
