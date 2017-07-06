using idata;
using model;
using System;
using System.Collections.Generic;
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
            return _dbContext.Innovations;
        }

        public void Insert(Innovation innovation)
        {
            using (_dbContext)
            {
                _dbContext.Innovations.Add(innovation);
                _dbContext.SaveChanges();
            }

        }
    }
}
