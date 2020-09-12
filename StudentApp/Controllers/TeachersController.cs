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
    [Authorize(Roles = "Teacher")]
    public class TeachersController : Controller
    {
       

        private ApplicationDbContext _context;

        public TeachersController()
        {
            _context = new ApplicationDbContext();
        }

    

        // GET: Teachers
        public ActionResult Index()
        {

            var students = _context.Students.ToList();

            var viewModel = new TeacherHomeViewModel
            {
                Students = students
            };
            
            return View(viewModel);
        }

        public ActionResult Messages()
        {
            

            return View();
        }

        public ActionResult RespondMessage(int id)
        {
            var contest = _context.Contests.Single(c => c.Id == id);

            return View(contest);
        }

        public ActionResult Details(int id)
        {

            var student = _context.Students.SingleOrDefault(s => s.Id == id);
            var disciplines = _context.Disciplines.ToList();

            string user = User.Identity.GetUserId();

            var teacher = _context.Teachers.Single(t => t.IdentityUserId == user);

            Grade grade = new Grade();

            var viewModel = new StudentDetailsViewModel
            {
                Student = student,
                Grade = grade,
                Disciplines = disciplines,
                Teacher = teacher
            };

            return View(viewModel);
        }

    }
}