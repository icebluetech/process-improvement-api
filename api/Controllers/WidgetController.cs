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
    public class WidgetController : Controller
    {
        private readonly IWidgetRepository _widgetRepository;

        public WidgetController(IWidgetRepository widgetRepositry)
        {
            _widgetRepository = widgetRepositry;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<Widget> Get()
        {
            return _widgetRepository.List();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/User/5
        [HttpGet("search")]
        public IEnumerable<Widget> Get(string term)
        {
            return _widgetRepository.Search(term);
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]Widget widget)
        {
            _widgetRepository.Insert(widget);
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
