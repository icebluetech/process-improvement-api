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
    public class ExperimentController : Controller
    {
        private readonly IExperimentRepository _experimentRepository;

        public ExperimentController(IExperimentRepository experimentRepository)
        {
            _experimentRepository = experimentRepository;
        }

        // GET: api/Experiment
        [HttpGet]
        public IEnumerable<Experiment> Get()
        {
            return _experimentRepository.List();
        }

        // GET: api/Experiment/5
        [HttpGet("{id}")]
        public Experiment Get(int id)
        {
            return _experimentRepository.Get(id);
        }

        // POST: api/Experiment
        [HttpPost]
        public void Post([FromBody]Experiment experiment)
        {
            _experimentRepository.Insert(experiment);
        }

        // PUT: api/Experiment/5
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
