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
    public class InnovationController : Controller
    {
        private readonly IInnovationRepository _innovationRepository;
        private readonly IInnovationUserRepository _innovationUserRepository;

        public InnovationController(IInnovationRepository innovationRepositry, IInnovationUserRepository innovationUserRepository)
        {
            _innovationRepository = innovationRepositry;
            _innovationUserRepository = innovationUserRepository;
        }

        // GET: api/Innovation
        [HttpGet]
        public IEnumerable<Innovation> Get()
        {
            var users = _innovationUserRepository.List();
            var innovations = _innovationRepository.List();
            return _innovationRepository.List();
        }

        // GET: api/Innovation/5
        [HttpGet("{id}")]
        public Innovation Get(int id)
        {
            return _innovationRepository.Get(id);
        }
        
        // POST: api/Innovation
        [HttpPost]
        public void Post([FromBody]Innovation innovation)
        {
            _innovationRepository.Insert(innovation);

            //_innovationUserRepository.Insert(innovation.InnovationUsers);
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
