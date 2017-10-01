using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using idata;
using model;
using api.Models;

namespace api.Controllers
{


    [Produces("application/json")]
    [Route("api/[controller]")]
    public class StateController : Controller
    {
        private readonly IBaseRepository<State> _repository;

        public StateController(IBaseRepository<State> repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<State> Get()
        {
            return _repository.List();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]State state)
        {
            _repository.Insert(state);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
