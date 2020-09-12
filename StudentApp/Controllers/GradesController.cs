using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentApp.Controllers
{
    public class GradesController : Controller
    {
        private ApplicationDbContext _context;

        public GradesController()
        {
            _context = new ApplicationDbContext();
        }



        // GET: Grades
        public ActionResult Edit(int id)
        {

            var grade = _context.Grades.SingleOrDefault(g => g.Id == id);

            if (grade == null)
            {
                return HttpNotFound();
            }

            return View(grade);
        }
    }
}