using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyStudentName() {
            Student student = new Student();
            student.age = 21;
            student.studentID = 1;
            student.studentName = "Ali kaakati";
            return View(student);
        }
    }
}