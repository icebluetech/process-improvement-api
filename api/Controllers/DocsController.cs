using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using idata;
using model;
using System.IO;

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
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Post()
        {
            var files = Request.Form.Files;

            var uploads = Path.Combine("https://processimprovement.file.core.windows.net", "uploads");
            foreach (var file in files)
            {
                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream("https://processimprovement.file.core.windows.net/uploads/test.txt", FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
            }

            //foreach (var file in files)
            //{
            //    var doc = new Doc { Name = file.Name };
            //    _docsRepository.Upload(doc);
            //}

            return Ok();
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
