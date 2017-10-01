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
    public class ReasonForActionController : Controller
    {
        private readonly IBaseRepository<ReasonForAction> _repository;

        public ReasonForActionController(IBaseRepository<ReasonForAction> repository)
        {
            _repository = repository;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<ReasonForAction> Get()
        {
            return _repository.List();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/User/5
        [HttpGet("search")]
        public IEnumerable<ReasonForAction> Get(string term)
        {
            Func<ReasonForAction, bool> t = (s) => s.Reason.ToLower() == term.ToLower();
            //var r = _repository.List().Where(s => s.Reason.ToLower() == term.ToLower());
            var test = _repository.Search(t);
            return test;
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]ReasonForAction reasonForAction)
        {
            _repository.Insert(reasonForAction);
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
