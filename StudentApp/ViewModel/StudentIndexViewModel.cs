using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.ViewModel
{
    public class StudentIndexViewModel
    {
        public IEnumerable<Grade> Grades { get; set; }
    }
}