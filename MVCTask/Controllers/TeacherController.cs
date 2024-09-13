using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTask.DataAccesLayer;

namespace MVCTask.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext appDbContext;

        public TeacherController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            var teacher = await appDbContext.Teachers.ToListAsync();
            return View(teacher);
        }
    }
}
