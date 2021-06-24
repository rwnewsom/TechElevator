using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CrumpetsController : ControllerBase
    {

        [HttpGet]
        public ActionResult<string> WhatAreCrumpets()
        {
            return "What are crumpets anyway?";
        }
    }
}
