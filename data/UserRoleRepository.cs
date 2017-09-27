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

        public IEnumerable<UserRole> Search(string term)
        {
            if (term != null)
            {
                return List().Where(u => u.Name.ToLower().Contains(term.ToLower()));
            }

            return List();
        }

        public void Insert(UserRole userRole)
        {
            using (_dbContext)
            {
                _dbContext.UserRoles.Add(userRole);
                _dbContext.SaveChanges();
            }

        }
    }
}
