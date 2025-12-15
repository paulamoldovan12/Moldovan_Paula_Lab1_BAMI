using Microsoft.AspNetCore.Mvc;
using Moldovan_Paula_Lab1.Models;

namespace Moldovan_Paula_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
        
    }
}
