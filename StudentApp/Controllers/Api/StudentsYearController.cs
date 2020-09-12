using AutoMapper;
using StudentApp.Dtos;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentApp.Controllers.Api
{
    public class StudentsYearController : ApiController
    {

        private ApplicationDbContext _context;

        public StudentsYearController()
        {
            _context = new ApplicationDbContext();
        }


        public IHttpActionResult GetStudentByYear(int id)
       {
            var students = _context.Students.Where(s => s.Class == id).ToList().Select(Mapper.Map<Student, StudentDto>);

            return Ok(students);
       }

    }
}
