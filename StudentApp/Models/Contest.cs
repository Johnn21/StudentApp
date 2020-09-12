using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Models
{
    public class Contest
    {
        public int Id { get; set; }

        public string Body { get; set; }




        public virtual Discipline Discipline { get; set; }
        public int? DisciplineId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }

        public virtual Student Student { get; set; }
        public int? StudentId { get; set; }

        public virtual Grade Grade { get; set; }
        public int? GradeId { get; set; }

    }
}