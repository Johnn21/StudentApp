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

    public class ResponseContestsController : ApiController
    {
        private ApplicationDbContext _context;

        public ResponseContestsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult RespondContest(ContestResponseDto contestResponseDto)
        {

            var contestResponse = Mapper.Map<ContestResponseDto, ContestResponse>(contestResponseDto);

            _context.ContestResponses.Add(contestResponse);
            _context.SaveChanges();

            contestResponseDto.Id = contestResponse.Id;

            return Created(new Uri(Request.RequestUri + "/" + contestResponse.Id), contestResponseDto);
        }

        public IHttpActionResult GetResponses()
        {
            string currentUser = User.Identity.GetUserId();

            var student = _context.Students.Single(s => s.IdentityUserId == currentUser);

            var responses = _context.ContestResponses.Where(c => c.StudentId == student.Id).ToList().Select(Mapper.Map<ContestResponse, ContestResponseDto>);

            return Ok(responses);
        }

        [HttpDelete]
        public IHttpActionResult DeleteResponse(int id)
        {
            var response = _context.ContestResponses.Single(c => c.Id == id);

            _context.ContestResponses.Remove(response);
            _context.SaveChanges();

            return Ok();

        }
    }
}
