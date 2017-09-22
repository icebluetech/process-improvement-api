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
    public class ProcessController : Controller
    {
        private readonly IProcessRepository _processRepository;

        public ProcessController(IProcessRepository processRepositry)
        {
            _processRepository = processRepositry;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<Process> Get()
        {
            return _processRepository.List();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public string Get(int id)
        { 
            return "value";
        }

        // GET: api/User/5
        [HttpGet("search")]
        public IEnumerable<Process> Get(string term)
        {
            return _processRepository.Search(term);
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]Process process)
        {
            _processRepository.Insert(process);
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
