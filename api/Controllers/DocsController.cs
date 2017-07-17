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
    public class DocsController : Controller
    {
        private readonly IDocsRepository _docsRepository;

        public DocsController(IDocsRepository docsRepository)
        {
            _docsRepository = docsRepository;
        }
        // GET: api/Docs
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Docs/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Docs
        [HttpPost]
        public void Post([FromBody]Doc doc)
        {
            _docsRepository.Upload(doc);
        }
        
        // PUT: api/Docs/5
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
