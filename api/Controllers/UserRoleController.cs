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
    public class UserRoleController : Controller
    {
        private readonly IUserRoleRepository _userRoleRepository;

        public UserRoleController(IUserRoleRepository userRoleRepositry)
        {
            _userRoleRepository = userRoleRepositry;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<UserRole> Get()
        {
            return _userRoleRepository.List();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }



        // POST: api/User
        [HttpPost]
        public void Post([FromBody]User user)
        {
            //_userRoleRepository.Insert(user);
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
