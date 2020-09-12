using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.ViewModel
{
    public class StudentDetailsViewModel
    {
        public Grade Grade { get; set; }
        public Student Student { get; set; }
        public IEnumerable<Discipline> Disciplines { get; set; }

        public Teacher Teacher { get; set; }

    }
}