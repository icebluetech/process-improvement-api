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
    public class BrainstormController : Controller
    {
        private readonly IBrainstormRepository _brainstormRepository;

        public BrainstormController(IBrainstormRepository brainstormRepository)
        {
            _brainstormRepository = brainstormRepository;
        }

        // GET: api/Brainstorm
        [HttpGet]
        public IEnumerable<Brainstorm> Get()
        {
            return _brainstormRepository.List();
        }

        // GET: api/Brainstorm/5
        [HttpGet("{id}")]
        public Brainstorm Get(int id)
        {
            return _brainstormRepository.Get(id);
        }

        // POST: api/Brainstorm
        [HttpPost]
        public void Post([FromBody]Brainstorm brainstorm)
        {
            _brainstormRepository.Insert(brainstorm);
        }

        // PUT: api/Brainstorm/5
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
