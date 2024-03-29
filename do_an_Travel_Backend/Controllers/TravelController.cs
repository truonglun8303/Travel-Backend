﻿using do_an_Travel_Backend.Service.Travels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace do_an_Travel_Backend.Controllers
{
    [Route("v1/api/travel")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        private readonly ITravelsService _travelsService;
        public TravelController(ITravelsService travelsService)
        {
            _travelsService= travelsService;
        }
        // GET: api/<Travel>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_travelsService.GetTravels());
        }

        // GET api/<Travel>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Travel>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Travel>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Travel>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
