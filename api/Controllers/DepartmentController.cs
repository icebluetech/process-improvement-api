using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using idata;
using model;
using System.IO;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.File;

namespace api.Controllers
{
    

    [Produces("application/json")]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        // GET: api/Docs
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _departmentRepository.List();
        }

        // GET: api/Docs/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/User/5
        [HttpGet("search")]
        public IEnumerable<Department> Get(string term)
        {
            return _departmentRepository.Search(term);
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]Department department)
        {
            _departmentRepository.Insert(department);
        }

        //PUT: api/Docs/5
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
