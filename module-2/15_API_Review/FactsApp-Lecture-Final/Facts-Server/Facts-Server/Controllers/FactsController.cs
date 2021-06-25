using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facts_Server.Controllers
{
    [Route("facts")]
    [ApiController]
    public class FactsController : ControllerBase
    {
        private FactsDao facts;

        public FactsController()
        {
            facts = new FactsDao();
        }

        
    }
}
