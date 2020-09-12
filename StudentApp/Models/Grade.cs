using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentApp.Models
{
    public class Grade
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 10)]
        public int Value { get; set; }

        public string Comment { get; set; }

        public DateTime DateAdded { get; set; }


        public virtual Discipline Discipline { get; set; }
        public int DisciplineId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public virtual Student Student { get; set; }
        public int StudentId { get; set; }

    }
}