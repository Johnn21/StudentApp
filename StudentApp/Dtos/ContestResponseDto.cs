using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Dtos
{
    public class ContestResponseDto
    {
        public int Id { get; set; }

        public string Body { get; set; }


        public virtual ContestDto Contest { get; set; }
        public int ContestId { get; set; }

        public virtual TeacherDto Teacher { get; set; }
        public int TeacherId { get; set; }

        public virtual StudentDto Student { get; set; }
        public int StudentId { get; set; }
    }
}