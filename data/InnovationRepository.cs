using idata;
using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace data
{
    public class InnovationRepository : IInnovationRepository
    {
        private readonly ProcessImprovementContext _dbContext;
        public InnovationRepository(ProcessImprovementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Innovation> List()
        {
            return IncludeAll();
        }

        public Innovation Get(int Id)
        {
            var all = IncludeAll();
            return all.Single(s => s.Id == Id);
        }

        public void Insert(Innovation innovation)
        {
            using (_dbContext)
            {
                _dbContext.Innovations.Add(innovation);
                _dbContext.SaveChanges();
            }

        }

        private IQueryable<Innovation> IncludeAll()
        {
            return _dbContext.Innovations.Include(s => s.InnovationType).Include(s => s.Category).Include(s => s.Process).Include(w=>w.Widget).Include(p => p.InnovationUsers).ThenInclude(p => p.User).ThenInclude(p => p.UserRole);
        }
    }
}
