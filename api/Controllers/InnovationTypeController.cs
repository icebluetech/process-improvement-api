using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using idata;
using model;

namespace api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class InnovationTypeController : Controller
    {
        private readonly IInnovationTypeRepository _innovationTypeRepository;

        public InnovationTypeController(IInnovationTypeRepository innovationTypeRepository)
        {
            _innovationTypeRepository = innovationTypeRepository;
        }

        // GET: api/Innovation
        [HttpGet]
        public IEnumerable<InnovationType> Get()
        {
            return _innovationTypeRepository.List();
        }

        // GET: api/Innovation/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/User/5
        [HttpGet("search")]
        public IEnumerable<InnovationType> Get(string term)
        {
            return _innovationTypeRepository.Search(term);
        }

        // POST: api/Innovation
        [HttpPost]
        public void Post([FromBody]InnovationType innovationType)
        {
            _innovationTypeRepository.Insert(innovationType);
        }
        
        // PUT: api/Innovation/5
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
