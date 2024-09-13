using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTask.DataAccesLayer;

namespace MVCTask.Controllers;

public class StudentController : Controller
{
    private readonly AppDbContext _appDbContext;

    public StudentController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Index()
    {
        var students = await _appDbContext.Students.ToListAsync();
        return View(students);
    }
}
