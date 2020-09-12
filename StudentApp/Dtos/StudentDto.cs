using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public string Sex { get; set; }
        public int? Age { get; set; }


       // public virtual IdentityUser IdentityUser { get; set; }
        public string IdentityUserId { get; set; }
    }
}