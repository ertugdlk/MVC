using Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{

    // localhost:5000/course
    public class CourseController : Controller
    {
        // action method
        // localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost]
        public IActionResult Apply(Student student)
        {
          Repository.AddStudent(student);
          //TODO: Implement Realistic Implementation
          return View("thanks" , student);
        }


        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "net core";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }

        // localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            return View();
        }
    }
}