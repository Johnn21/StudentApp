using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Models
{
    public class ContestResponse
    {
        public int Id { get; set; }

        public string Body { get; set; }

        



        public virtual Contest Contest { get; set; }
        public int ContestId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public virtual Student Student { get; set; }
        public int StudentId { get; set; }


    }
}