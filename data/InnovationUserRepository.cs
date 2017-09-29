using idata;
using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace data
{
    public class InnovationUserRepository : IInnovationUserRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public InnovationUserRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<InnovationUser> List()
        {
            return _dbContext.InnovationUsers.Include(i => i.Innovation).Include(i => i.User);
        }

        public void Insert(InnovationUser innovationUser)
        {
            using (_dbContext)
            {
                _dbContext.InnovationUsers.Add(innovationUser);
                _dbContext.SaveChanges();
            }

        }

        public void Insert(IEnumerable<InnovationUser> innovationUsers)
        {
            using (_dbContext)
            {
                foreach (var innovationUser in innovationUsers)
                {

                    _dbContext.InnovationUsers.Add(innovationUser);

                }
            }

            _dbContext.SaveChanges();
        }
    }
}
