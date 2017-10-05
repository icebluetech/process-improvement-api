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
    public class ActionPlanController : Controller
    {
        private readonly IBaseRepository<ActionPlan> _repository;

        public ActionPlanController(IBaseRepository<ActionPlan> repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<ActionPlan> Get()
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
        public void Post([FromBody]ActionPlan actionPlan)
        {
            _repository.Insert(actionPlan);
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
