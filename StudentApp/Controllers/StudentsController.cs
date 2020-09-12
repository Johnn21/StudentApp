using Microsoft.AspNet.Identity;
using StudentApp.Models;
using StudentApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentsController : Controller
    {

        private ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Students
        public ActionResult Index()
        {
            string currentUser = User.Identity.GetUserId();

            var student = _context.Students.Single(s => s.IdentityUserId == currentUser);


            return View(student);
        }

        public ActionResult GradeDetails(int id)
        {

            ViewBag.id = id;

            var grade = _context.Grades.Single(g => g.Id == id);

            return View(grade);
        }

       
       

        public ActionResult Messages()
        {
            return View();
        }

      
    }
}