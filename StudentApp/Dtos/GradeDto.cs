using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Dtos
{
    public class GradeDto
    {
        public int Id { get; set; }

       
        public int Value { get; set; }

        public string Comment { get; set; }

        public DateTime DateAdded { get; set; }


        public virtual DisciplineDto Discipline { get; set; }
        public int DisciplineId { get; set; }

        public virtual TeacherDto Teacher { get; set; }
        public int TeacherId { get; set; }

        public virtual StudentDto Student { get; set; }
        public int StudentId { get; set; }
    }
}