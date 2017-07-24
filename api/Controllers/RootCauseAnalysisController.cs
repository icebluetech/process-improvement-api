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
    public class RootCauseAnalysisController : Controller
    {
        private readonly IRootCauseAnalysisRepository _rootCauseAnalysisRepository;

        public RootCauseAnalysisController(IRootCauseAnalysisRepository rootCauseAnalysisRepository)
        {
            _rootCauseAnalysisRepository = rootCauseAnalysisRepository;
        }

        // GET: api/RootCauseAnalysis
        [HttpGet]
        public IEnumerable<RootCauseAnalysis> Get()
        {
            return _rootCauseAnalysisRepository.List();
        }

        // GET: api/RootCauseAnalysis/5
        [HttpGet("{id}")]
        public RootCauseAnalysis Get(int id)
        {
            return _rootCauseAnalysisRepository.Get(id);
        }

        // POST: api/RootCauseAnalysis
        [HttpPost]
        public void Post([FromBody]RootCauseAnalysis rootCauseAnalysis)
        {
            _rootCauseAnalysisRepository.Insert(rootCauseAnalysis);
        }

        // PUT: api/RootCauseAnalysis/5
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
