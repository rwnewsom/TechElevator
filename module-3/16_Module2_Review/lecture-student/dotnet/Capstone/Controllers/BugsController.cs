using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        [HttpGet] // GET /Bugs
        public ActionResult GetAllBugs()
        {
            List<Bug> bugs = new List<Bug>();

            Bug newBug = new Bug();
            newBug.Title = "C# Testing Bug";
            newBug.Id = 42;
            newBug.IsOpen = true;
            newBug.Resolution = "this is just for testing";

            bugs.Add(newBug);

            return Ok(bugs);
        }
    }
}
