using idata;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public UserRoleRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<UserRole> List()
        {
            return _dbContext.UserRoles;
        }
    }
}
