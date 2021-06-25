using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactsServer.Controllers
{
    //[Route("api/[controller]")]
    [Route("facts")]
    [ApiController]
    public class FactsController : ControllerBase
    {
        private FactsDao facts;

        public FactsController()
        {
            facts = new FactsDao();
        }

        //1. Add a new GET method to handle gets to /facts
        //This should return the results of the DAO's GetAllFacts method
        [HttpGet()]
        public ActionResult<List<ChuckNorrisFact>> ListFacts()
        {
            return facts.GetAllFacts();
        }

        //2. Add a method to allow folks to POST a new fact.
        //This should call the DAO's AddFact method with the new fact.

        [HttpPost]
        public ActionResult<ChuckNorrisFact> AddFact(ChuckNorrisFact fact)
        {
            if (fact==null)
            {
                return BadRequest("Not a valid fact");
            }
            return facts.AddFact(fact);
        }
    }
}
