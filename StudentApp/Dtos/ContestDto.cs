using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Dtos
{
    public class ContestDto
    {
        public int Id { get; set; }

        public string Body { get; set; }




        public virtual DisciplineDto Discipline { get; set; }
        public int? DisciplineId { get; set; }

    //    public virtual Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }

        public virtual StudentDto Student { get; set; }
        public int? StudentId { get; set; }

    //    public virtual Grade Grade { get; set; }
        public int? GradeId { get; set; }
    }
}