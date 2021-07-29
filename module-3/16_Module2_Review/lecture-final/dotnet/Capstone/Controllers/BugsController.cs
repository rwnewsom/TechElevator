using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    //[Route("[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly IBugDAO bugDao;

        public BugsController(IBugDAO bugDao)
        {
            this.bugDao = bugDao;
        }

        [HttpGet("bugs")] // GET /Bugs
        [AllowAnonymous]
        public ActionResult GetAllBugs()
        {
            IEnumerable<Bug> bugs = this.bugDao.GetAllBugs();

            return Ok(bugs);
        }

        [HttpPost("bugs")]
        [Authorize]
        public ActionResult AddBug(Bug bug)
        {
            Bug newBug = this.bugDao.InsertBug(bug);

            return Created($"bugs/{newBug.Id}", newBug);
        }


        [HttpPut("bugs/{id}")]
        [Authorize]
        public ActionResult EditBug(int id, Bug updatedBug)
        {
            Bug bug = this.bugDao.GetBugById(id);
            if (bug == null)
            {
                return NotFound("No bug could be found with that ID. It may have been deleted.");
            }

            Bug newBug = this.bugDao.UpdateBug(updatedBug);

            return Ok(newBug);
        }

        [HttpGet("bugs/{id}")] // GET /Bugs/42
        [AllowAnonymous]
        public ActionResult GetBugById(int id)
        {
            Bug bug = this.bugDao.GetBugById(id);

            if (bug == null)
            {
                return NotFound("No bug could be found with that ID. It may have been deleted.");
            }

            return Ok(bug);
        }

        [HttpDelete("bugs/{id}")]
        [Authorize(Roles = "admin")]
        public ActionResult DeleteBug(int id)
        {
            Bug bug = this.bugDao.GetBugById(id);
            if (bug == null)
            {
                return NotFound("No bug could be found with that ID. It may have been deleted.");
            }

            this.bugDao.DeleteBug(id);

            return NoContent();
        }
    }
}
