using AutoMapper;
using Microsoft.AspNet.Identity;
using StudentApp.Dtos;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentApp.Controllers.Api
{
    public class GradesController : ApiController
    {
        private ApplicationDbContext _context;

        public GradesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetStudentGrades(int id)
        {
            var grades = _context.Grades.Where(g => g.StudentId == id).ToList().Select(Mapper.Map<Grade, GradeDto>);

            return Ok(grades);

        }

        public IHttpActionResult GetGrade(int id)
        {
            var grade = _context.Grades.SingleOrDefault(g => g.Id == id);


            if (grade == null)
                return NotFound();


            return Ok(Mapper.Map<Grade, GradeDto>(grade));
            
        }


        public IHttpActionResult GetGrades(int id)
        {
            string currentUser = User.Identity.GetUserId();

            var teacher = _context.Teachers.Single(t => t.IdentityUserId == currentUser);

            var student = _context.Students.Single(s => s.Id == id);

            var grades = _context.Grades.Where(g => g.TeacherId == teacher.Id).Where(g => g.StudentId == student.Id).ToList().Select(Mapper.Map<Grade, GradeDto>);

            return Ok(grades);
        }


        //POST /api/grades
        [HttpPost]
        public IHttpActionResult AddGrades(GradeDto gradeDto)
        {
            gradeDto.DateAdded = DateTime.Now;

            var grade = Mapper.Map<GradeDto, Grade>(gradeDto);


            _context.Grades.Add(grade);
            _context.SaveChanges();

            gradeDto.Id = grade.Id;


            return Created(new Uri(Request.RequestUri + "/" + grade.Id), gradeDto);
        }

        //DELETE /api/grades/id
        [HttpDelete]
        public IHttpActionResult DeleteGrades(int id)
        {
            var grade = _context.Grades.SingleOrDefault(g => g.Id == id);

            if(grade == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Grades.Remove(grade);
            _context.SaveChanges();

            return Ok();

        }

        //PUT /api/grades/id
        [HttpPut]
        public IHttpActionResult EditGrade(GradeDto gradeDto)
        {
            var gradeDb = _context.Grades.SingleOrDefault(g => g.Id == gradeDto.Id);

            if(gradeDb == null)
            {
                return NotFound();
            }

             gradeDb.Value = gradeDto.Value;
             gradeDb.Comment = gradeDto.Comment;

           // Mapper.Map(gradeDto, gradeDb);


            _context.Entry(gradeDb).State = EntityState.Modified;

           
            try
            {
                _context.SaveChanges();
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }

            return Ok();
        }
    }
}
