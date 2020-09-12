using AutoMapper;
using Microsoft.AspNet.Identity;
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
    public class ContestsController : ApiController
    {
        private ApplicationDbContext _context;

        public ContestsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult AddContest(ContestDto contestDto)
        {

            var contest = Mapper.Map<ContestDto, Contest>(contestDto);

            _context.Contests.Add(contest);
            _context.SaveChanges();

            contestDto.Id = contest.Id;

            return Created(new Uri(Request.RequestUri + "/" + contest.Id), contestDto);

        }

        public IHttpActionResult GetContests()
        {
            string currentUser = User.Identity.GetUserId();

            var teacher = _context.Teachers.Single(t => t.IdentityUserId == currentUser);

            var contests = _context.Contests.Where(c => c.TeacherId == teacher.Id).ToList().Select(Mapper.Map<Contest, ContestDto>);

            return Ok(contests);
        }

        [HttpDelete]
        public IHttpActionResult DeleteContest(int id)
        {
            var contest = _context.Contests.Single(c => c.Id == id);

            _context.Contests.Remove(contest);
            _context.SaveChanges();

            return Ok();
        }

      

       

    }
}
