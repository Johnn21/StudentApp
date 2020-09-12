using AutoMapper;
using Microsoft.Ajax.Utilities;
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
    public class StudentsController : ApiController
    {

        private ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/students
        public IHttpActionResult GetStudents()
        {
           
            var students = _context.Students.ToList().Select(Mapper.Map<Student, StudentDto>);

            return Ok(students);
        }

        //GET /api/students/id
          public IHttpActionResult GetStudent(int id)
          {

            var student = _context.Students.SingleOrDefault(s => s.Id == id);

            if(student == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Student, StudentDto>(student));

           }

     /*   public IHttpActionResult GetStudentByYear(int id)
        {
            var students = _context.Students.Where(s => s.Class == id).ToList();
            return Ok(students);
        }*/

    }
}
