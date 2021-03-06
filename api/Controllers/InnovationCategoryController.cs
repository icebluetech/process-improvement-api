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
    public class InnovationCategoryController : Controller
    {
        private readonly IInnovationCategoryRepository _innovationCategoryRepository;

        public InnovationCategoryController(IInnovationCategoryRepository innovationCategoryRepository)
        {
            _innovationCategoryRepository = innovationCategoryRepository;
        }

        // GET: api/Innovation
        [HttpGet]
        public IEnumerable<InnovationCategory> Get()
        {
            return _innovationCategoryRepository.List();
        }

        // GET: api/Innovation/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/User/5
        [HttpGet("search")]
        public IEnumerable<InnovationCategory> Get(string term)
        {
            return _innovationCategoryRepository.Search(term);
        }

        // POST: api/Innovation
        [HttpPost]
        public void Post([FromBody]InnovationCategory innovationCategory)
        {
            _innovationCategoryRepository.Insert(innovationCategory);
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
