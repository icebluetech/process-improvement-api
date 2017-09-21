using idata;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class UserRepository : IUserRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public UserRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<User> List()
        {
            return _dbContext.Users;
        }

        public IEnumerable<User> Search(string term)
        {
            if (term != null)
            {
#if DEBUG
                return Mocks.UserList().Where(u => u.Name.ToLower().Contains(term.ToLower()));
#else
    return List().Where(u => u.Name.ToLower().Contains(term.ToLower()));
#endif
            }
            return new List<User>();
        }

        public void Insert(User user)
        {
            using (_dbContext)
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
            }

        }
    }
}
